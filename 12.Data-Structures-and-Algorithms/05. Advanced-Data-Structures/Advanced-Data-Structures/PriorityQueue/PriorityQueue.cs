namespace PriorityQueueImplementation
{
    using System;

    public class PriorityQueue<T> where T : IComparable
    {
        private readonly BinaryHeap<T> heap;

        public PriorityQueue()
        {
            this.heap = new BinaryHeap<T>();
        }

        public T Peek()
        {
            return this.heap.Peak();
        }

        public void Enqueue(T element)
        {
            this.heap.Insert(element);
        }

        public T Dequeue()
        {
            var element = this.heap.Peak();
            this.heap.Pop();

            return element;
        }
    }
}
