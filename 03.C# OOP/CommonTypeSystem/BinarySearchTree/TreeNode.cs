using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class TreeNode<T> where T : IComparable<T>
    {
        public TreeNode(T value)
        {
            Data = value;
        }
        public T Data
        {
            get;
            set;
        }
        public TreeNode<T> Left;
        public TreeNode<T> Right;
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
