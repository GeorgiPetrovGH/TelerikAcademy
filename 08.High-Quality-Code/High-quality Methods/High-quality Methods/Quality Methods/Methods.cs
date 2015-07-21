﻿namespace Quality_Methods
{
    using System;
    public class Methods
    {
        public static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            if ((a + b < c) || (a + c < b) || (b + c < a))
            {
                throw new ArgumentOutOfRangeException("No side can be longer than the sum of the other two sides");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            return area;
        }

        public static string DigitToString(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("Invalid digit.");
            }
        }

        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("Input array cannot be null or empty");
            }

            int maxElement = elements[0];
            
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > elements[0])
                {
                    maxElement = elements[i];
                }
            }
            return maxElement;
        }

        public static void PrintAsNumber(object number, string format)
        {
            double numberAsDouble;
            bool isConvertibleToNumber = double.TryParse(number.ToString(), out numberAsDouble);
            
            if (!isConvertibleToNumber)
            {
                throw new ArgumentException("Number parameter is not an object convertible to number.");
            }

            switch (format)
            {
                case "f": 
                    Console.WriteLine("{0:f2}", number);
                    break;
                case "%": 
                    Console.WriteLine("{0:p0}", number);
                    break;
                case "r":
                    Console.WriteLine("{0,8}", number);
                    break;
                default:
                    throw new ArgumentException("Invalid formattiong option.");
            }
        }
    }
}