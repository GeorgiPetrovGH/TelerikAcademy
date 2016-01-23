/*
Problem 12.* Zero Subset

We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
Assume that repeating the same subset several times is not a problem.
 */

using System;
class Subset
{
    static void Main()
    {
        Console.WriteLine("Enter five integer numbers");

        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("d = ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("e = ");
        int e = int.Parse(Console.ReadLine());

        bool noSubset = false;

       // if (a == 0) { Console.WriteLine("{0} = 0", a); noSubset = true; }
       // if (b == 0) { Console.WriteLine("{0} = 0", b); noSubset = true; }
       // if (c == 0) { Console.WriteLine("{0} = 0", c); noSubset = true; }
       // if (d == 0) { Console.WriteLine("{0} = 0", d); noSubset = true; }
       // if (e == 0) { Console.WriteLine("{0} = 0", e); noSubset = true; }
       
        if (a + b == 0) { Console.WriteLine("{0} + {1} = 0", a, b); noSubset = true; }
        if (a + c == 0) { Console.WriteLine("{0} + {1} = 0", a, c); noSubset = true; }
        if (a + d == 0) { Console.WriteLine("{0} + {1} = 0", a, d); noSubset = true; }
        if (a + e == 0) { Console.WriteLine("{0} + {1} = 0", a, e); noSubset = true; }
        if (b + c == 0) { Console.WriteLine("{0} + {1} = 0", b, c); noSubset = true; }
        if (b + d == 0) { Console.WriteLine("{0} + {1} = 0", b, d); noSubset = true; }
        if (b + e == 0) { Console.WriteLine("{0} + {1} = 0", b, e); noSubset = true; }
        if (c + d == 0) { Console.WriteLine("{0} + {1} = 0", c, d); noSubset = true; }
        if (c + e == 0) { Console.WriteLine("{0} + {1} = 0", c, e); noSubset = true; }
        if (d + e == 0) { Console.WriteLine("{0} + {1} = 0", d, e); noSubset = true; }

        if (a + b + c == 0) { Console.WriteLine("{0} + {1} + {2} = 0", a, b, c); noSubset = true; }
        if (a + b + d == 0) { Console.WriteLine("{0} + {1} + {2} = 0", a, b, d); noSubset = true; }
        if (a + b + e == 0) { Console.WriteLine("{0} + {1} + {2} = 0", a, b, e); noSubset = true; }
        if (a + c + d == 0) { Console.WriteLine("{0} + {1} + {2} = 0", a, c, d); noSubset = true; }
        if (a + c + e == 0) { Console.WriteLine("{0} + {1} + {2} = 0", a, c, e); noSubset = true; }
        if (a + d + e == 0) { Console.WriteLine("{0} + {1} + {2} = 0", a, d, e); noSubset = true; }
        if (b + c + d == 0) { Console.WriteLine("{0} + {1} + {2} = 0", b, c, d); noSubset = true; }
        if (b + c + e == 0) { Console.WriteLine("{0} + {1} + {2} = 0", b, c, e); noSubset = true; }
        if (b + d + e == 0) { Console.WriteLine("{0} + {1} + {2} = 0", b, d, e); noSubset = true; }
        if (c + d + e == 0) { Console.WriteLine("{0} + {1} + {2} = 0", c, d, e); noSubset = true; }

        if (a + b + c + d == 0) { Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d); noSubset = true; }
        if (a + b + c + e == 0) { Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, e); noSubset = true; }
        if (a + b + d + e == 0) { Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, d, e); noSubset = true; }
        if (a + c + d + e == 0) { Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, c, d, e); noSubset = true; }
        if (b + c + d + e == 0) { Console.WriteLine("{0} + {1} + {2} + {3} = 0", b, c, d, e); noSubset = true; }

        if (a + b + c + d + e == 0) { Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e); noSubset = true; }

        if (noSubset == false) { Console.WriteLine("no zero subset"); }
    }
}

