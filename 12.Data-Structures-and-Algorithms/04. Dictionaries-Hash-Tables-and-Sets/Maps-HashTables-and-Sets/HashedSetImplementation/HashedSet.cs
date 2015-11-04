namespace HashedSetImplementation
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    using HashTableImplementation;

    public class HashedSet<T> : IEnumerable<T> where T : IComparable
    {
        private HashTable<int, T> values;

        public HashedSet()
        {
            this.values = new HashTable<int, T>();
        }

        public int Count
        {
            get
            {
                return this.values.Count;
            }
        }

        public T Find(T value)
        {
            var index = value.GetHashCode();
            if (index < 0)
            {
                index *= -1;
            }
            return this.values.Find(index);
        }

        public bool Contains(T value)
        {
            var index = value.GetHashCode();
            if(index < 0)
            {
                index *= -1;
            }
            return this.values.Contains(index);
        }

        public void Add(T value)
        {
            var index = value.GetHashCode();
            if(index < 0)
            {
                index *= -1;
            }

            if (!this.values.Contains(index))
            {
                this.values.Add(index, value);
            }
        }

        public void Remove(T value)
        {
            var index = value.GetHashCode();
            if (index < 0)
            {
                index *= -1;
            }
            this.values.Remove(index);
        }

        public void Clear()
        {
            this.values.Clear();
        }

        public HashedSet<T> Union(HashedSet<T> values)
        {
            var result = new HashedSet<T>();

            foreach (var item in this)
            {
                result.Add(item);
            }

            foreach (var item in values)
            { 
                 result.Add(item);
            }

            return result;
        }

        public HashedSet<T> Intersect(HashedSet<T> values)
        {
            var result = new HashedSet<T>();

            foreach (var item in this)
            {
                foreach (var anotherItem in values)
                {
                    if (anotherItem.CompareTo(item) == 0)
                    {
                        result.Add(item);
                    }
                }
            }

            return result.Count == 0 ? null : result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var pair in this.values)
            {
                yield return pair.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
