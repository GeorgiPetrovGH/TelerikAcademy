namespace FindWordsInLargeText
{
    using System;    
    using System.IO;   
    using System.Text;    

    public class Startup
    {
        public static void Main()
        {
            var trie = new Trie();

            // File is smaller than 100MB due to uploading restrictions, but you can make it bigger by doing 10-15 copy/pastes of its content :)
            var words = new StreamReader("..\\..\\text.txt").ReadToEnd().Split(new char[] { '.', '!', '?', ';', ' ', ':', ',', '-', '<', '>', '/', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            {
                trie.AddWord(word);
            }

            var result = new StringBuilder();

            var searchedWords = new StreamReader("..\\..\\words.txt").ReadToEnd().Split(new char[] { '.', '!', '?', ';', ' ', ':', ',', '-', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int occurs = 0;
            foreach (var word in searchedWords)
            {
                result.Append(word);
                result.Append(" -> ");
                trie.TryFindWord(word, out occurs);
                result.Append(occurs);
                result.AppendLine(" times");
            }

            Console.Write(result.ToString());
        }
    }
}
