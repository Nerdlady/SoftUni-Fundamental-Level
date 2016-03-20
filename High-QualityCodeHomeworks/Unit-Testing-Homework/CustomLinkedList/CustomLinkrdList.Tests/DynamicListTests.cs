namespace CustomLinkrdList.Tests
{
    using System;

    using CustomLinkedList;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DynamicListTests
    {
        private static DynamicList<int> dynamicList;

        [TestInitialize]
        public void TestInitialize()
        {
            dynamicList = new DynamicList<int>();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Set_TestAtNegativeIndex_ShouldThrowArgumentOutOfRangeException()
        {
            var dynamicList = new DynamicList<int>();
            var wrongIndex = dynamicList[-1];
        }

        [TestMethod]
        public void Count_TestCountOnNewListCreation_ShouldPassTest()
        {
            var dynamicList = new DynamicList<int>();
            int initialCount = dynamicList.Count;
            Assert.AreEqual(0, initialCount, "A newly created list should have a count of 0.");
        }

        [TestMethod]
        public void Elements_TestPositionsOfElementsAddedInSequence_ShouldPassTest()
        {
            var dynamicList = new DynamicList<int>();
            dynamicList.Add(3);
            dynamicList.Add(5);

            var firstElement = dynamicList[0];
            var secondElement = dynamicList[1];

            Assert.AreEqual(3, firstElement, "The element at index 0 should be the first element added to the list.");
            Assert.AreEqual(5, secondElement, "The element at index 1 should be the second element added to the list.");
        }

       
        [TestMethod]
        public void Add_TestAddElement_ShouldPassTest()
        {
            var dynamicList = new DynamicList<int>();
            dynamicList.Add(5);

            var indexAtPositionZero = dynamicList[0];
            Assert.AreEqual(5, indexAtPositionZero, "Added element should be 5");
        }


        [TestMethod]
        public void RemoveAt_TestRemovingElementAtCurrentPosition_ShouldPassTest()
        {
            var dynamicList = new DynamicList<int>();
            dynamicList.Add(3);
            dynamicList.Add(5);
            dynamicList.Add(7);

            dynamicList.RemoveAt(1);

            var indexAtPositionOne = dynamicList[1];
            Assert.AreEqual(7, indexAtPositionOne, "Element at position one should become 7");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveAt_TestAtNegativeIndex_ShouldReturn()
        {
            var dynamicList = new DynamicList<int>();
            dynamicList.RemoveAt(-5);
        }

        [TestMethod]
        public void Remove_TestRemovingCurretElement_ShouldPassTest()
        {
            var dynamicList = new DynamicList<int>();
            dynamicList.Add(3);
            dynamicList.Add(5);
            dynamicList.Add(7);

            dynamicList.Remove(3);

            var indexAtPositionOne = dynamicList[0];
            Assert.AreEqual(5, indexAtPositionOne, "Element at position zero should become 5");
        }

        [TestMethod]
        public void Remove_TestMissingElement_ShouldRerunMinusOne()
        {
            var dynamicList = new DynamicList<int>();
            dynamicList.Add(3);
            dynamicList.Add(5);
            dynamicList.Add(7);

            var missingElement = dynamicList.Remove(2);
            Assert.AreEqual(-1, missingElement, "The returned index of a non-existing element should be -1.");
        }

        [TestMethod]
        public void IndexOf_TestIndexOfCurrentElement_ShouldPassTest()
        {
            var dynamicList = new DynamicList<int>();
            dynamicList.Add(3);
            dynamicList.Add(5);
            dynamicList.Add(7);

            var indexOfSeven = dynamicList.IndexOf(7);
            Assert.AreEqual(2, indexOfSeven, "The index of the searched element should be 2");
        }

        [TestMethod]
        public void Contains_TestContainsElement_ShouldPassTest()
        {
            var dynamicList = new DynamicList<int>();
            dynamicList.Add(3);
            dynamicList.Add(5);
            dynamicList.Add(7);

            var contains = dynamicList.Contains(5);
            Assert.IsTrue(contains, "Dynamic list contains 5");
        }

    }
}
