/*
Problem 4. Print a Deck of 52 Cards

Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers).
The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
The card faces should start from 2 to A.
Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
 */

using System;
class PrintDeck
{
    static void Main()
    {
        int a = 3;
        int b = 4;
        int c = 5;
        int d = 6;

        Console.WriteLine("Standart deck of 52 play cards contain:");
        for (int i = 2; i < 11; i++)
        {
            Console.WriteLine("{0} of " + (char)c + ", {0} of " + (char)d + ", {0} of " + (char)a + ", {0} of " + (char)b, Convert.ToString(i).PadLeft(2));
        }

        string J = "J", Q = "Q", K = "K", Ace = "A";        
        Console.WriteLine("{0} of " + (char)c + ", {0} of " + (char)d + ", {0} of " + (char)a + ", {0} of " + (char)b, J.PadLeft(2));
        Console.WriteLine("{0} of " + (char)c + ", {0} of " + (char)d + ", {0} of " + (char)a + ", {0} of " + (char)b, Q.PadLeft(2));
        Console.WriteLine("{0} of " + (char)c + ", {0} of " + (char)d + ", {0} of " + (char)a + ", {0} of " + (char)b, K.PadLeft(2));
        Console.WriteLine("{0} of " + (char)c + ", {0} of " + (char)d + ", {0} of " + (char)a + ", {0} of " + (char)b, Ace.PadLeft(2));
    }                                                                       
}

