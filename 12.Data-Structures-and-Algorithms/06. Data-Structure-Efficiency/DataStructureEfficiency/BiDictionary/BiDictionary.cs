namespace BiDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Wintellect.PowerCollections;

    public class BiDictionary<K1, K2, V>
    {
        private readonly MultiDictionary<K1, V> firstKeyDictionary;
        private readonly MultiDictionary<K2, V> secondKeyDictionary;
        private readonly MultiDictionary<Tuple<K1, K2>, V> dualKeyDictionary;

        public BiDictionary()
        {
            firstKeyDictionary = new MultiDictionary<K1, V>(true);
            secondKeyDictionary = new MultiDictionary<K2, V>(true);
            dualKeyDictionary = new MultiDictionary<Tuple<K1, K2>, V>(true);
        }

        public void Add(K1 firstKey, K2 secondKey, V value)
        {
            this.firstKeyDictionary.Add(firstKey, value);
            this.secondKeyDictionary.Add(secondKey, value);

            var complexKey = new Tuple<K1, K2>(firstKey, secondKey);
            this.dualKeyDictionary.Add(complexKey, value);
        }

        public ICollection<V> FindByFirstKey(K1 key)
        {
            return this.firstKeyDictionary[key];
        }

        public ICollection<V> FindBySecondKey(K2 key)
        {
            return this.secondKeyDictionary[key];
        }

        public ICollection<V> FindByTwoKeys(K1 firstKey, K2 secondKey)
        {
            var complexKey = new Tuple<K1, K2>(firstKey, secondKey);

            return this.dualKeyDictionary[complexKey];
        }

        public bool ContainsFirstKey(K1 key)
        {
            return this.firstKeyDictionary.ContainsKey(key);
        }

        public bool ContainsSecondKey(K2 key)
        {
            return this.secondKeyDictionary.ContainsKey(key);
        }

        public bool ContainsCompositeKey(Tuple<K1, K2> key)
        {
            return this.dualKeyDictionary.ContainsKey(key);
        }

        public bool ContainsByFirstKey(KeyValuePair<K1, V> item)
        {
            return this.firstKeyDictionary.Contains(item.Key, item.Value);
        }

        public bool ContainsBySecondKey(KeyValuePair<K2, V> item)
        {
            return this.secondKeyDictionary.Contains(item.Key, item.Value);
        }

        public bool ContainsByCompositeKey(KeyValuePair<Tuple<K1, K2>, V> item)
        {
            return this.dualKeyDictionary.Contains(item.Key, item.Value);
        }

        public bool RemoveByFirstKey(KeyValuePair<Tuple<K1, K2>, V> item)
        {
            this.secondKeyDictionary.Remove(item.Key.Item2, item.Value);
            this.dualKeyDictionary.Remove(item.Key, item.Value);

            return this.firstKeyDictionary.Remove(item.Key.Item1, item.Value);
        }

        public bool RemoveBySecondKey(KeyValuePair<Tuple<K1, K2>, V> item)
        {
            this.firstKeyDictionary.Remove(item.Key.Item1, item.Value);
            this.dualKeyDictionary.Remove(item.Key, item.Value);
            return this.secondKeyDictionary.Remove(item.Key.Item2, item.Value);
        }

        public bool RemoveByCompositeKey(KeyValuePair<Tuple<K1, K2>, V> item)
        {
            this.secondKeyDictionary.Remove(item.Key.Item2, item.Value);
            this.dualKeyDictionary.Remove(item.Key, item.Value);
            return this.firstKeyDictionary.Remove(item.Key.Item1, item.Value);
        }

        public void Clear()
        {
            this.firstKeyDictionary.Clear();
            this.secondKeyDictionary.Clear();
            this.dualKeyDictionary.Clear();
        }
    }
}
