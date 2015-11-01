namespace LinkedList
{
    using System;

    public class LinkedList<T> where T : IComparable
    {

        public LinkedList()
        {
            this.FirstItem = null;
            this.Count = 0;
        }

        public ListItem<T> FirstItem { get; set; }

        public int Count { get; private set; }

        public bool Contains(T value)
        {
            var currentItem = this.FirstItem;
            while (currentItem != null)
            {
                if (currentItem.Value.CompareTo(value) == 0)
                {
                    return true;
                }

                currentItem = currentItem.NextItem;
            }

            return false;
        }

        public void AddLast(T value)
        {
            if (this.FirstItem == null)
            {
                this.FirstItem = new ListItem<T>(value);
            }
            else
            {
                var currentItem = this.FirstItem;
                while (currentItem.NextItem != null)
                {
                    currentItem = currentItem.NextItem;
                }

                currentItem.NextItem = new ListItem<T>(value);
            }

            this.Count++;
        }

        public void Remove(T value)
        {
            if (this.FirstItem == null)
            {
                return;
            }

            var currentItem = this.FirstItem;
            if (currentItem.Value.CompareTo(value) == 0)
            {
                this.RemoveFirst();
                return;
            }

            while (currentItem.NextItem != null)
            {
                if (currentItem.NextItem.Value.CompareTo(value) == 0)
                {
                    currentItem.NextItem = currentItem.NextItem.NextItem;
                    this.Count--;
                    return;
                }

                currentItem = currentItem.NextItem;
            }
        }

        public void AddFirst(T value)
        {
            var newFirst = new ListItem<T>(value);
            newFirst.NextItem = this.FirstItem;
            this.FirstItem = newFirst;
            this.Count++;
        }

        public void RemoveFirst()
        {
            if (this.FirstItem == null)
            {
                return;
            }

            this.FirstItem = this.FirstItem.NextItem;
            this.Count--;
        }
    }
}
