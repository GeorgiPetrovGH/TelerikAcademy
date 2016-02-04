using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class GenericList<T> where T : IComparable
    {
        private T[] list;
        private int capacity;
        
        public GenericList(int capacity)
        {
            this.list = new T[capacity];
            this.capacity = 0;
        }
              
        public int Count
        {
            get
            {
                return this.capacity;
            }
        }
        
        public T Max()
        {
            T result = default(T);
            if (this.Count > 0)
            {
                result = this.list[0];
                for (int i = 1; i < this.capacity; i++)
                {
                    if (result.CompareTo(this.list[i]) < 0)
                    {
                        result = this.list[i];
                    }
                }
            }
            return result;
        }

        public T Min()
        {
            T result = default(T);
            if (this.Count > 0)
            {
                result = this.list[0];
                for (int i = 1; i < this.capacity; i++)
                {
                    if (result.CompareTo(this.list[i]) > 0)
                    {
                        result = this.list[i];
                    }
                }
            }
            return result;
        }
        
        private void CheckRange(int index)
        {
            if (index < 0 || index > this.capacity)
            {
                throw new IndexOutOfRangeException();
            }
        }
        
        private void DoubleListSize()
        {
            int newSize = (this.list.Length == 0) ? 2 : this.list.Length * 2;
            T[] newList = new T[newSize];
            for (int i = 0; i < this.capacity; i++)
            {
                newList[i] = this.list[i];
            }
            this.list = newList;
        }

        public T this[int index]
        {
            get
            {
                CheckRange(index);
                return this.list[index];
            }
            set
            {
                CheckRange(index);
                this.list[index] = value;
            }
        }

        public void Add(T element)
        {
            if (capacity == this.list.Length)
            {
                DoubleListSize();
            }
            this.list[capacity] = element;
            this.capacity++;
        }

        public void InsertAt(int index, T element)
        {
            CheckRange(index);
            if (capacity == this.list.Length)
            {
                DoubleListSize();
            }
            for (int i = this.capacity; i > index; i--)
            {
                this.list[i] = this.list[i - 1];
            }
            this.list[index] = element;
            this.capacity++;
        }

        public void RemoveAt(int index)
        {
            CheckRange(index);
            for (int i = index + 1; i < this.capacity; i++)
            {
                this.list[i - 1] = this.list[i];
            }
            this.list[this.capacity--] = default(T);
        }

        public int IndexOf(T element)
        {
            int index = -1;
            for (int i = 0; i < this.capacity; i++)
            {
                if (this.list[i].Equals(element))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public void Clear()
        {
            for (int i = 0; i < this.capacity; i++)
            {
                this.list[i] = default(T);
            }
            this.capacity = 0;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.capacity; i++)
            {
                result.Append(String.Format("{0} ", this.list[i]));
            }
            return result.ToString().Trim();
        }

    }

}
