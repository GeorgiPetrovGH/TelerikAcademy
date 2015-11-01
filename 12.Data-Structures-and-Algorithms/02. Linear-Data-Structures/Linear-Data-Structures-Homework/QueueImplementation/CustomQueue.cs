namespace QueueImplementation
{
    using System;
    using System.Collections.Generic;

    public class CustomQueue<T> where T : IComparable
    {
        private LinkedList<T> values;

        public CustomQueue()
        {
            this.values = new LinkedList<T>();
        }

        public int Count
        {
            get
            {
                return this.values.Count;
            }
        }

        public bool Contains(T value)
        {
            return this.values.Contains(value);
        }

        public void Enqueue(T value)
        {
            this.values.AddLast(value);
        }

        public T Peek()
        {
            

            return this.values.First.Value;
        }

        public T Dequeue()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The Queue is empty.");
            }

            var element = this.Peek();
            this.values.RemoveFirst();
            return element;
        }
    }
}
