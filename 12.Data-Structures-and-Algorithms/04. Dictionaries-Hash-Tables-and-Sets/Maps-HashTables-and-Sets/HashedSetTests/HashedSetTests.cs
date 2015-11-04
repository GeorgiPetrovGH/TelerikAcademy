namespace HashedSetTests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using HashedSetImplementation;    

    [TestClass]
    public class HashedSetTests
    {
        [TestMethod]
        public void ConstructorShouldCreateEmptyHashedSetWithCountZero()
        {
            var testSet = new HashedSet<string>();

            Assert.AreEqual(0, testSet.Count);
        }

        [TestMethod]
        public void AddingToCollectionShouldIncreaseItsCount()
        {
            var testSet = new HashedSet<string>();
            int expected = testSet.Count + 1;

            testSet.Add("Pesho");

            Assert.AreEqual(expected, testSet.Count);
        }

        [TestMethod]
        public void AddingToCollectionMoreElementsThanItsCapacityShouldWorkFine()
        {
            var testSet = new HashedSet<string>();
            
            for (int i = 0; i < 100; i++)
            {
                testSet.Add("Pesho" + i);
            }

            Assert.AreEqual(100, testSet.Count);
        }

        [TestMethod]
        public void AddingExistingElementShouldDoNothing()
        {
            var testSet = new HashedSet<string>();

            testSet.Add("Pesho");
            testSet.Add("Pesho");
            testSet.Add("Pesho");
            testSet.Add("Pesho");

            Assert.AreEqual(1, testSet.Count);
        }

        [TestMethod]
        public void ContainsShouldReturnFalseWhenNoElementIsFound()
        {
            var testSet = new HashedSet<string>();

            Assert.IsFalse(testSet.Contains("Gosho"));
        }

        [TestMethod]
        public void ContainsShouldReturnTrueWhenElementIsFound()
        {
           var  testSet = new HashedSet<string>();

            testSet.Add("John");

            Assert.IsTrue(testSet.Contains("John"));
        }

        [TestMethod]
        public void FindShouldReturnCorrectValueWhenSearchingForExistingElement()
        {
            var testSet = new HashedSet<string>();
            testSet.Add("John");

            Assert.AreEqual("John", testSet.Find("John"));
        }

        [TestMethod]
        public void RemovingExistingElementShouldWorkCorrectly()
        {
            var testSet = new HashedSet<string>();
            testSet.Add("John");

            testSet.Remove("John");

            Assert.IsTrue(testSet.Count == 0 && testSet.Find("John") == null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemovingNotExistingElementShouldThrow()
        {
            var testSet = new HashedSet<string>();
            testSet.Remove("John");
        }

        [TestMethod]
        public void ClearShouldEmptyCollection()
        {
            var testSet = new HashedSet<string>();
            testSet.Add("Pesho");
            testSet.Add("Gosho");

            testSet.Clear();
            int countAfterClearing = testSet.Count;

            Assert.AreEqual(0, countAfterClearing);
        }

        //[TestMethod]
        //public void UnionShouldWorkCorrectly()
        //{
        //    var testSet = new HashedSet<string>();
        //    testSet.Add("John");
        //    testSet.Add("Jane");            
        //
        //    var anotherTestSet = new HashedSet<string>();
        //    anotherTestSet.Add("Pesho");
        //    anotherTestSet.Add("Gosho");            
        //
        //    var union = testSet.Union(anotherTestSet);
        //
        //    Assert.IsTrue(
        //        union.Contains("John")
        //        && union.Contains("Jane")
        //        && union.Contains("Pesho")
        //        && union.Contains("Gosho")
        //        && 4 == union.Count);
        //}

        [TestMethod]
        public void IntersectWithCollectionsWithNoCommonElementsShouldReturnNull()
        {
            var testSet = new HashedSet<string>();
            testSet.Add("Pesho");
            testSet.Add("Gosho");

            var anotherTestSet = new HashedSet<string>();
            anotherTestSet.Add("Kiro");
            anotherTestSet.Add("Joro");

            var intersection = testSet.Intersect(anotherTestSet);

            Assert.IsNull(intersection);
        }
    }
}
