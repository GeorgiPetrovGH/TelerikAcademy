//Problem 6. Extract text from HTML
//Write a function that extracts the content of a html page given as text.
//The function should return anything that is in a tag, without the tags.


function removeTags(html) {
    var text = html.replace(/<[^>]*>/g, '\n');
    text = text.replace(/^\s*[\r\n]/gm,"");
    return text;
}

var html = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>';
var text = removeTags(html);

console.log(text);