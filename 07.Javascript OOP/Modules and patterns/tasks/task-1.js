/* Task Description */
/* 
* Create a module for a Telerik Academy course
  * The course has a title and presentations
    * Each presentation also has a title
    * There is a homework for each presentation
  * There is a set of students listed for the course
    * Each student has firstname, lastname and an ID
      * IDs must be unique integer numbers which are at least 1
  * Each student can submit a homework for each presentation in the course
  * Create method init
    * Accepts a string - course title
    * Accepts an array of strings - presentation titles
    * Throws if there is an invalid title
      * Titles do not start or end with spaces
      * Titles do not have consecutive spaces
      * Titles have at least one character
    * Throws if there are no presentations
  * Create method addStudent which lists a student for the course
    * Accepts a string in the format 'Firstname Lastname'
    * Throws if any of the names are not valid
      * Names start with an upper case letter
      * All other symbols in the name (if any) are lowercase letters
    * Generates a unique student ID and returns it
  * Create method getAllStudents that returns an array of students in the format:
    * {firstname: 'string', lastname: 'string', id: StudentID}
  * Create method submitHomework
    * Accepts studentID and homeworkID
      * homeworkID 1 is for the first presentation
      * homeworkID 2 is for the second one
      * ...
    * Throws if any of the IDs are invalid
  * Create method pushExamResults
    * Accepts an array of items in the format {StudentID: ..., Score: ...}
      * StudentIDs which are not listed get 0 points
    * Throw if there is an invalid StudentID
    * Throw if same StudentID is given more than once ( he tried to cheat (: )
    * Throw if Score is not a number
  * Create method getTopStudents which returns an array of the top 10 performing students
    * Array must be sorted from best to worst
    * If there are less than 10, return them all
    * The final score that is used to calculate the top performing students is done as follows:
      * 75% of the exam result
      * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
*/

function solve() {
	function validateTitle(title){
      if(title === null || typeof title !== 'string') {
        throw new Error('Invalid input of title');
      }
      
      if(title.trim() === '' || title !== title.trim()) {
        throw new Error('Invalid title');
      }

      if(title.match(/[\s]{2,}/)){
        throw new Error('Invalid spacing');
      }
    }

  function validatePresentations(presentations) {
    if(presentations === null || !Array.isArray(presentations)) {
      throw new Error('Invalid input of presentations');
    }

    if(presentations.length === 0) {
      throw new Error('Empty array of presentations');
    }

    presentations.forEach(function(title) {
      validateTitle(title);
    });
  }

  function validateName(name) {
    if(name === null || typeof name !== 'string') {
      throw new Error('Invalid input of student name');
    }

    if(name.trim() === '') {
      throw new Error('Empty input of student name');
    }

    var names = name.split(' ');

    if(names.length !== 2) {
      throw new Error('Invalid name');
    }

    names.forEach(function(n) {
      if(!(/[A-Z][a-z]*/.test(n))) {
        throw new Error('Invalid name');
      }
    });

    return {
      firstname: names[0], 
      lastname: names[1]
    };          
  }

  var Course = {
    init: function(title, presentations) {      
      this.title = title;
      this.presentations = presentations;
      this.students = [];

      return this;
		},
		addStudent: function(name) {
      var student = validateName(name);
      var id = this.students.length + 1;
      
      student.id = id;

      this.students.push(student);

      return id;
		},
		getAllStudents: function() {
      return this.students.slice();
		},
		submitHomework: function(studentID, homeworkID) {
      studentID = studentID * 1;
      homeworkID = homeworkID * 1;
      if(studentID < 1 || studentID > this.students.length) {
        throw new Error('Invalid studentID');
      }

      if(homeworkID < 1 || homeworkID > this.presentations.length) {
        throw new Error('Invalid homeworkID');
      }
		},
		pushExamResults: function(results) {
		},
		getTopStudents: function() {
		}


	};

  Object.defineProperty(Course, 'title', {
      get: function () {
        return Course._title;
      },
      set: function(title){
        validateTitle(title);
        Course._title = title;
      }
    });

    Object.defineProperty(Course, 'presentations', {
      get: function () {
        return Course._presentations;
      },
      set: function(presentations){
        validatePresentations(presentations);
        Course._presentations = presentations;
      }
    });

    Object.defineProperty(Course, 'students', {
        get: function () {
            return Course._students;
        },
        set: function(students){
            Course._students = students;
        }
    });



	return Course;
}


module.exports = solve;
