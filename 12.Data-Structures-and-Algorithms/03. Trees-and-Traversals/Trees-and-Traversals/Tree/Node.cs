namespace Tree
{
    using System.Collections.Generic;

    public class Node<T>
    {
        public Node(T value)
        {
            this.Value = value;
            this.HasParent = false;
            this.Children = new List<Node<T>>();
        }

        public T Value { get; private set; }

        public List<Node<T>> Children { get; private set; }

        public bool HasParent { get; private set; }

        public void AddChild(Node<T> child)
        {
            child.HasParent = true;
            this.Children.Add(child);
        }
    }
}
