namespace HashTableImplementation
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class HashTable<K, V> : IEnumerable<KeyValuePair<K, V>> where K : IComparable
    {
        private const int InitialCapacity = 16;
        private const double ResizeRatio = 0.75;

        private int capacity;

        private LinkedList<KeyValuePair<K, V>>[] values;

        public HashTable()
        {
            this.capacity = InitialCapacity;
            this.values = new LinkedList<KeyValuePair<K, V>>[InitialCapacity];
        }

        public int Count
        {
            get
            {
                int count = 0;
                foreach (var list in this.values)
                {
                    if (list != null)
                    {
                        count += list.Count;
                    }
                }

                return count;
            }
        }

        public IEnumerable<K> Keys
        {
            get
            {
                return this.values
                    .Where(x => x != null)
                    .Where(x => x.Count != 0)
                    .Select(x => x.First.Value.Key)
                    .ToList();
            }
        }

        public V this[K key]
        {
            get
            {
                if (!this.Contains(key))
                {
                    throw new ArgumentException("Key does not exist in the collection");
                }

                return this.Find(key);
            }
            set
            {
                if (!this.Contains(key))
                {
                    throw new ArgumentException("Key does not exist in the collection");
                }

                this.Remove(key);
                this.Add(key, value);
            }
        }

        public bool Contains(K key)
        {
            return this.Keys.Any(k => k.CompareTo(key) == 0);
        }

        public void Add(K key, V value)
        {
            int keyHashCode = key.GetHashCode();
            int index = keyHashCode % this.values.Length;
            if( index < 0)
            {
                index *= -1;
            }

            if (this.values[index] == null)
            {
                this.values[index] = new LinkedList<KeyValuePair<K, V>>();
            }

            this.values[index].AddLast(new KeyValuePair<K, V>(key, value));
            if (this.Count > ResizeRatio * this.capacity)
            {
                this.Resize();
            }
        }

        public V Find(K key)
        {
            int keyHashCode = key.GetHashCode();
            int index = keyHashCode % this.values.Length;
            if(index < 0)
            {
                index *= -1;
            }

            if (this.values[index] != null && this.values[index].Count != 0)
            {
                foreach (var pair in this.values[index])
                {
                    if (pair.Key.CompareTo(key) == 0)
                    {
                        return pair.Value;
                    }
                }
            }

            return default(V);           
        }

        public void Remove(K key)
        {
            if (!this.Contains(key))
            {
                throw new ArgumentException("No such item in the hash table.");
            }

            int keyHashCode = key.GetHashCode();
            int index = keyHashCode % this.values.Length;
            if(index < 0)
            {
                index *= -1;
            }

            if (this.values[index] != null && this.values[index].Count != 0)
            {
                var elementToDelete = this.values[index].FirstOrDefault(e => e.Key.CompareTo(key) == 0);

                this.values[index].Remove(elementToDelete);
            }
        }

        public void Clear()
        {
            this.values = new LinkedList<KeyValuePair<K, V>>[InitialCapacity];
        }

        private void Resize()
        {
            LinkedList<KeyValuePair<K, V>>[] valuesToMove = this.values; 
            this.capacity *= 2;
            this.values = new LinkedList<KeyValuePair<K, V>>[this.capacity];
            foreach (var list in valuesToMove)
            {
                if (list != null)
                {
                    foreach (var pair in list)
                    {
                        this.Add(pair.Key, pair.Value);
                    }
                }
            }
        }


        public IEnumerator<KeyValuePair<K, V>> GetEnumerator()
        {
            foreach (var list in this.values)
            {
                if (list != null)
                {
                    foreach (var pair in list)
                    {
                        yield return pair;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
