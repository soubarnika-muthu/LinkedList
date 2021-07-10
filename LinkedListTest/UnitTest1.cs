using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LinkedList;

namespace LinkedListTest

{
    [TestClass]
    public class UnitTest1
    {
        MyLinkedList<int> linkedList;

        [TestInitialize]
        public void SetUp()
        {
            linkedList = new MyLinkedList<int>();
        }
        [TestMethod]
        public void SearchTest1()
        {
            //Assign
            linkedList.AddFirst(70);
            linkedList.AddFirst(30);
            linkedList.AddFirst(56);
            //act
            int actual = linkedList.Search(30);
            int expected = 1;
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void SearchTest2()
        {
            //Assign
            linkedList.AddFirst(70);
            linkedList.AddFirst(30);
            linkedList.AddFirst(56);
            //act
            int actual = linkedList.Search(30);
            int expected = 1;
            linkedList.InsertToNext(45, 30);

            //Assert
            Assert.AreEqual(expected, actual);
            linkedList.DisplayList();

        }
    }
}
