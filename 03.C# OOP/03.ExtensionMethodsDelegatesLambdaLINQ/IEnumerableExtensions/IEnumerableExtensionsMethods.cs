/*
Problem 2. IEnumerable extensions

Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions
{
    public static class IEnumerableExtensionsMethods
    {
        public static T Sum<T>(this IEnumerable<T> collection) where T : IConvertible, IComparable
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("The collection is empty.");
            }
            T result = (dynamic)0;
            foreach (T item in collection)
            {
                result += (dynamic)item;
            }
            return result;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : IConvertible, IComparable
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("The collection is empty.");
            }
            T min = collection.First();
            foreach (var element in collection)
                if (element.CompareTo(min) < 0)
                    min = element;
            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : IConvertible, IComparable
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("The collection is empty!");
            }
            T max = collection.First();
            foreach (var element in collection)
                if (element.CompareTo(max) > 0)
                    max = element;
            return max;
        }

        public static T Product<T>(this IEnumerable<T> collection) where T : IConvertible, IComparable
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("The collection is empty!");
            }
            T result = (dynamic)1;
            foreach (T item in collection)
            {
                result *= (dynamic)item;
            }
            return result;
        }

        public static T Average<T>(this IEnumerable<T> collection) where T : IConvertible, IComparable
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("The collection is empty!");
            }
            T result = (dynamic) collection.Sum() / collection.Count();
            return result;
        }

    }
}
