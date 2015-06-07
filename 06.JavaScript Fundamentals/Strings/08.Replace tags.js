//Problem 8. Replace tags
//Write a JavaScript function that replaces in a HTML document given as string all the tags
//<a href="…">…</a> with corresponding tags [URL=…]…/URL].


function replaceTag(html) {
    while (html.indexOf('<a href') >= 0) {
        html = html.replace('<a href="', '[URL=').
        replace('">', ']').
        replace('</a>', '[/URL]');
    }
    return html;
}

var paragraph = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. ' +
                'Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>',
    result = replaceTag(paragraph);

console.log(result);

