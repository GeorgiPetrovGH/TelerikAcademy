/*
Problem 13. Reverse sentence

Write a program that reverses the words in given sentence.
*/

using System;
using System.Linq;
using System.Text;
class ReverseTheSentence
{
    static char[] charArray = { ',', '.', '!', '?', '-' };
    static void Main()
    {
        string sentence = "C# is not C++, not PHP and not Delphi!";
        Console.WriteLine(ReverseSentence(sentence));
    }

    static string ReverseSentence(string text)
    {
        string[] reverse = text.Split(' ');
        StringBuilder sb = new StringBuilder();
        char lastChar = new char();
        for (int i = reverse.Length - 1; i >= 0; i--)
        {
            string temp = reverse[i];
            if (i == reverse.Length - 1)
            {
                if (charArray.Contains(temp[temp.Length - 1]))
                {
                    lastChar = temp[temp.Length - 1];
                    sb.Append(temp);
                    sb.Remove(sb.Length - 1, 1);
                    sb.Append(" ");
                }
            }
            else
            {
                if (charArray.Contains(temp[temp.Length - 1]))
                {
                    sb.Remove(sb.Length - 1, 1);
                    sb.Append(temp[temp.Length - 1] + " ");
                    sb.Append(temp);
                    sb.Remove(sb.Length - 1, 1);
                    sb.Append(" ");
                }
                else
                {
                    sb.Append(temp);
                    sb.Append(" ");
                }
            }
        }
        sb.Remove(sb.Length - 1, 1);
        sb.Append(lastChar);
        return sb.ToString();
    }
}

