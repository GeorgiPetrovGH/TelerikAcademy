//Problem 7. Parse URL
//Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] 
//and extracts from it the [protocol], [server] and [resource] elements.
//Return the elements in a JSON object.


function parseUrl(url) {
    var indexOfSlash = url.indexOf('/'),
        indexOfSecondSlash = url.indexOf('/', indexOfSlash + 1),
        indexOfThirdSlash = url.indexOf('/', indexOfSecondSlash + 1),
        result = {};

    result.protocol = url.substring(0, url.indexOf(':'));
    result.server = url.substring(indexOfSecondSlash + 1, indexOfThirdSlash);
    result.resource = url.substring(indexOfThirdSlash);

    return result;
}

var url = 'http://telerikacademy.com/Courses/Courses/Details/239',
    result = parseUrl(url);
console.log(result);