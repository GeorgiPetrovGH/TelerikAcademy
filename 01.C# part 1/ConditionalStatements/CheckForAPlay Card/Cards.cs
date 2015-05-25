/*
Problem 3. Check for a Play Card

Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.
Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:
 */

using System;
using System.Collections.Generic;
class Cards
    {
        static void Main()
        {
            Console.Write("Enter card sign: ");
            string card = Console.ReadLine();
            List<string> cards = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            if (cards.Contains(card))
            {
                Console.WriteLine("yes");
            }
            else 
            {
                Console.WriteLine("no");
            }

        }
    }

