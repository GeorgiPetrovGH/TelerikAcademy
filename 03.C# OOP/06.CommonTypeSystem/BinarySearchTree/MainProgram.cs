/*
Problem 6.* Binary search tree

Define the data structure binary search tree with operations for "adding new element", "searching element" and "deleting elements". 
It is not necessary to keep the tree balanced.
Implement the standard methods from System.Object – ToString(), Equals(…), GetHashCode() and the operators for comparison == and !=.
Add and implement the ICloneable interface for deep copy of the tree.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class MainProgram
    {
        static void Main()
        {
            var bst = new BinarySearchTree<int>();
            for (int i = 0; i < 20; i++)
            {
                bst.Insert(i + 1);
            }
            Console.WriteLine("Initially: {0}", bst);
            bst.BalanceTree();
            Console.WriteLine("Balanced: {0}", bst);
            Console.WriteLine("Traverse and print (DFS)");
            bst.TraverseDFS();
            var bst2 = new BinarySearchTree<int>();
            for (int i = 0; i < 20; i++)
            {
                bst2.Insert(i + 1);
            }
            bst2.BalanceTree();
            Console.WriteLine("Second tree (balanced): {0}", bst2);
            // returns true only if both trees have the same number of nodes,
            // nodes hold equal values, and trees are balanced in the same way
            Console.WriteLine("First tree equals second tree? {0}", bst.Equals(bst2));
            var bst3 = (BinarySearchTree<int>)bst2.Clone();
            Console.WriteLine("Third tree, cloned from second: {0}", bst3);
            Console.WriteLine("Traverse and print cloned tree (DFS)");
            bst3.TraverseDFS();
        }
    }
}
