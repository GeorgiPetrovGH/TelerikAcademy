//Problem 10. Find palindromes
//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

function isPalindrome(word){
    for(var ind = 0; ind < word.length / 2; ind++){
        if(word[ind] !== word[word.length - ind - 1]){
            return false;
        }
    }
    return true;
}

function extractPalindromes(text){
    var palindromes = [];
    var words = text.match(/\b\w+\b/g);

    for(var ind in words){
        if(isPalindrome(words[ind])){
            palindromes.push(words[ind]);
        }
    }
    return palindromes;
}

var text = 'Pesho exe gosho. What the... lamal ABBA, palindrom.';

console.log(extractPalindromes(text).join(', '));
