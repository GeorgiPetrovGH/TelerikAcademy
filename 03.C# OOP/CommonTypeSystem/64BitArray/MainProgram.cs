/*
Problem 5. 64 Bit array

Define a class BitArray64 to hold 64 bit values inside an ulong value.
Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64BitArray
{
    class MainProgram
    {
        static void Main()
        {
            BitArray64 arr = new BitArray64(7u);
            BitArray64 arr2 = new BitArray64(8u);
            Console.WriteLine(arr);
            arr[1] = 0;
            Console.WriteLine(arr);
            Console.WriteLine(arr == arr2);
            Console.WriteLine(arr.Equals(arr));
            Console.WriteLine(arr != arr2);
        }
    }
}
