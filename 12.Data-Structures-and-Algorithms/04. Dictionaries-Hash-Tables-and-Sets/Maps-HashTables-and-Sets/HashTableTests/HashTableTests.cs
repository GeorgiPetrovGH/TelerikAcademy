namespace HashTableTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using HashTableImplementation;
    using System.Collections.Generic;

    [TestClass]
    public class HashTableTests
    {
        [TestMethod]
        public void ConstructorShouldCreateEmptyHashTableWithCountZero()
        {
            var testTable = new HashTable<string, int>();

            Assert.AreEqual(0, testTable.Count);
        }

        [TestMethod]
        public void ContainsKeyShouldReturnFalseWhenNoKeyIsFound()
        {
            var testTable = new HashTable<string, int>();

            Assert.IsFalse(testTable.Contains("some key"));
        }

        [TestMethod]
        public void ContainsKeyShouldReturnTrueWhenKeyIsFound()
        {
            var testTable = new HashTable<string, int>();

            testTable.Add("some key", 42);

            Assert.IsTrue(testTable.Contains("some key"));
        }

        [TestMethod]
        public void AddingToCollectionShouldIncreaseItsCountWith1()
        {
            var testTable = new HashTable<string, int>();
            int expected = testTable.Count + 1;

            testTable.Add("some key", 42);

            Assert.AreEqual(expected, testTable.Count);
        }

        [TestMethod]
        public void AddingToCollectionMoreElementsThanItsCapacityShouldWorkFine()
        {
            var testTable = new HashTable<string, int>();
            
            for (int i = 0; i < 100; i++)
            {
                testTable.Add("some key" + i, i);
            }

            Assert.AreEqual(100, testTable.Count);
        }

        [TestMethod]
        public void FindShouldReturnCorrectValueWhenSearchingForExistingElement()
        {
            var testTable = new HashTable<string, int>();
            testTable.Add("some key", 42);

            Assert.AreEqual(42, testTable.Find("some key"));
        }

        [TestMethod]        
        public void FindShouldReturnCorrectValueWhenSearchingForNotExistingElement()
        {
            var testTable = new HashTable<string, int>();
            testTable.Add("some key", 42);

            Assert.AreEqual(default(int), testTable.Find("some"));
        }

        [TestMethod]
        public void RemovingExistingElementShouldWorkCorrectly()
        {
            var testTable = new HashTable<string, int>();
            testTable.Add("some key", 42);

            testTable.Remove("some key");

            Assert.IsTrue(testTable.Count == 0 && testTable.Find("some key") == default(int));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemovingNotExistingElementShouldThrow()
        {
            var testTable = new HashTable<string, int>();
            testTable.Remove("some key");
        }

        [TestMethod]
        public void ClearShouldEmptyCollection()
        {
            var testTable = new HashTable<string, int>();
            testTable.Add("some key", 42);
            testTable.Add("another key", 42);

            testTable.Clear();
            int countAfterClearing = testTable.Count;

            Assert.AreEqual(0, countAfterClearing);
        }

        [TestMethod]
        public void IndexerWithExistingKeyShouldReturnCorrectValue()
        {
            var testTable = new HashTable<string, int>();
            testTable.Add("some key", 42);

            Assert.AreEqual(42, testTable["some key"]);
        }

        [TestMethod]
        public void IndexerWithExistingKeyShouldSetValueCorrectly()
        {
            var testTable = new HashTable<string, int>();
            testTable.Add("some key", 42);
            testTable["some key"]++;

            Assert.AreEqual(43, testTable.Find("some key"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IndexerGetterWithNotExistingKeyShouldThrow()
        {
            var testTable = new HashTable<string, int>();
            var someNumber = testTable["not existing key"];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IndexerSetterWithNotExistingKeyShouldThrow()
        {
            var testTable = new HashTable<string, int>();
            testTable["not existing key"] = 12;
        }
    }
}
