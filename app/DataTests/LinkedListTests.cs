using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Tests
{
    [TestClass()]
    public class LinkedListTests
    {
        [TestMethod()]
        public void ToArrayTest()
        {
            Node<string> node;
            var list = new SinglyLinkedList<string>();

            list.Add("x");
            list.Add("y");
            list.Add("z");
            Assert.IsTrue(list.Count == 3);
            var arr = list.ToArray();
            Assert.IsTrue(arr.Length == 3);
            Assert.IsTrue(arr[0] == "x");
            Assert.IsTrue(arr[1] == "y");
            Assert.IsTrue(arr[2] == "z");

        }
    }
}