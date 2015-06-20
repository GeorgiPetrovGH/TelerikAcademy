/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
function solve() {
	var library = (function () {
		var books = [];
		var categories = [];

		function validateBookArguments(book){
			var BOOKPROPERTIES = 5;

			if(Object.keys(book).length < BOOKPROPERTIES) {
				throw new Error('Missing book properties');
			}

			for(var param in book){
				if(typeof book[param] === 'undefined'){
					throw new Error('Invalid book property');
				}
			}
		}

		function validateBookIsUnique(book){
			for(var i =0, len = books.length; i < len; i+=1){
				if(books[i].title === book.title || books[i].isbn === book.isbn){
					throw new Error('Book already exist');
				}
			}
		}

		function validateAuthor(book){
			if(book.author === ''){
				throw new Error('Author can not be empty string');
			}
		}

		function validateIsbn(book){
			if(book.isbn.length !== 10 && book.isbn.length !== 13){
				throw new Error('Not valid ISBN');
			}
			if(book.isbn.split().every(function(item){
				return isNaN(item);
			})){
				throw new Error('Not valid ISBN');
			}
		}

		function validateTitle(book){
			if(book.title.length < 2 || book.title.length > 100){
				throw new Error('Not valid title');
			}
		}

		function validateCategory(book){
			if(book.category.length < 2 || book.category.length > 100){
				throw new Error('Not valid category');
			}
		}

		
		function listBooks(property) {
            var booksTemp = books.slice();
            if (property) {
                var prop;
                for (prop in property) {
                    if (property.hasOwnProperty(prop)) {
                        booksTemp = books.filter(function(item) {
                            return item[prop] === property[prop];
                        });
                    }
                }
            }
            books = booksTemp.slice();
            return books.sort(function(a, b) {
                return a.id - b.id;
            });
        }

        function addCategory(name) {
            categories[name] = {
                books: [],
                ID: categories.length + 1
            };
        }

		function addBook(book) {
			book.ID = books.length + 1;

			validateBookArguments(book);
			validateBookIsUnique(book);
            validateAuthor(book);
            validateIsbn(book);
            validateTitle(book);
            validateCategory(book);

            if(categories.indexOf(book.category) < 0) {
                addCategory(book.category);
            }

            categories[book.category].books.push(book);

			books.push(book);
			
			return book;
		}

		function listCategories(category) {
            var categoriesNames = [];

            Array.prototype.push.apply(categoriesNames, Object.keys(categories));

            return categoriesNames;
        }

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());
	return library;
}
module.exports = solve;
