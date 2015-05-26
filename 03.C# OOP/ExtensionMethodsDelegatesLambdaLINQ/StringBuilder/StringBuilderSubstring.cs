/*
 Problem 1. StringBuilder.Substring

 Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder
 and has the same functionality as Substring in the class String.
 */

using System;
using System.Text;

namespace StringBuilderExtensionMethod
{
    public static class StringBuilderSubstring
    {
        public static StringBuilder Substring(this StringBuilder sb, int startIndex, int length)
        {
            if (startIndex < 0 || startIndex >= sb.Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (length < 0)
            {
                throw new ArgumentException("Length can not be less than zero.");
            }
            if (startIndex + length > sb.Length)
            {
                throw new ArgumentException("The length of the substring is too great.");
            }

            string str = sb.ToString();
            StringBuilder result = new StringBuilder();            
            for (int position = 0; position < length; position++)
            {
                result.Append(str[startIndex + position]);
            }
            return result;
        }

        public static StringBuilder Substring(this StringBuilder sb, int startIndex)
        {
            if (startIndex < 0 || startIndex >= sb.Length)
            {
                throw new IndexOutOfRangeException();
            }

            string str = sb.ToString();
            StringBuilder result = new StringBuilder();
            for (int position = startIndex; position < sb.Length; position++)
            {
                result.Append(str[position]);
            }            
            return result;
        }
    }
}
