namespace Tree
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Startup
    {
        private const string Input = @"7
2 4
3 2
5 0
3 5
5 6
5 1";

        public static void Main()
        {
            Console.SetIn(new StringReader(Input));
            var nodes = ReadInput();
            
            var rootNode = FindRoot(nodes);
            Console.WriteLine("Root node -> {0}", rootNode.Value);

            var leafs = FindLeafs(nodes);
            Console.WriteLine("Leaf nodes -> {0}", string.Join(", ", leafs));

            var middleNodes = FindMiddleNodes(nodes);
            Console.WriteLine("Middle nodes -> {0}", string.Join(", ", middleNodes));

            int longestPath = FindLongestPath(rootNode);
            Console.WriteLine("Longest path from root -> {0}", longestPath);
        }

        private static Node<int>[] ReadInput()
        {
            int n = int.Parse(Console.ReadLine());

            var nodes = new Node<int>[n];

            for (int i = 0; i < n; i++)
            {
                nodes[i] = new Node<int>(i);
            }

            for (int i = 1; i <= n - 1; i++)
            {
                var nodesFromInputLine = Console.ReadLine();
                var nodesParts = nodesFromInputLine.Split(' ');
                var parentNode = int.Parse(nodesParts[0]);
                var childNode = int.Parse(nodesParts[1]);               

                nodes[parentNode].AddChild(nodes[childNode]);
            }

            return nodes;
        }

        private static Node<int> FindRoot(Node<int>[] nodes)
        {
            foreach (var node in nodes)
            {
                if (!node.HasParent)
                {
                    return node;
                }
            }

            throw new ArgumentException("Tree has no root.");
        }

        private static List<int> FindLeafs(Node<int>[] nodes)
        {
            var leafs = new List<int>();

            foreach (var node in nodes)
            {
                if (node.Children.Count == 0)
                {
                    leafs.Add(node.Value);
                }
            }

            return leafs;
        }

        private static List<int> FindMiddleNodes(Node<int>[] nodes)
        {
            var middleNodes = new List<int>();

            foreach (var node in nodes)
            {
                if (node.Children.Count != 0 && node.HasParent)
                {
                    middleNodes.Add(node.Value);
                }
            }

            return middleNodes;
        }

        private static int FindLongestPath(Node<int> node)
        {
            if (node.Children.Count == 0)
            {
                return 0;
            }

            int longestPath = 0;
            foreach (var child in node.Children)
            {
                longestPath = Math.Max(longestPath, FindLongestPath(child));
            }

            return longestPath + 1;
        }
    }
}
