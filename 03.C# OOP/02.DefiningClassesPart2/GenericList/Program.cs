using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>(10);
            list.Add(1);
            list.InsertAt(1, 2);
            list.InsertAt(2, 3);
            list.Add(4);
            list.RemoveAt(0);
            list.InsertAt(3,5);
            Console.WriteLine("Our list contains of:");
            Console.WriteLine(list);

            Console.WriteLine("Max element: {0}", list.Max());
            Console.WriteLine("Min element: {0}", list.Min());

        }
    }
}
