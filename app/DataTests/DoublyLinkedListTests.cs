using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Tests
{
    [TestClass()]
    public class DoublyLinkedListTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Node<string> node;
            var list = new DoublyLinkedList<string>();

            list.Add("x");
            Assert.IsTrue(list.Count == 1);

            node = list.Contains("x");
            Assert.IsTrue(node.Value == "x");
            Assert.IsTrue(node.Next == null);
            Assert.IsTrue(((DoublyNode<string>)node).Prev == null);

            list.Add("y");
            Assert.IsTrue(list.Count == 2);

            node = list.Contains("x");
            Assert.IsTrue(node.Value == "x");
            Assert.IsTrue(node.Next.Value == "y");
            Assert.IsTrue(node.Next.Next == null);
            node = list.Contains("y");
            Assert.IsTrue(((DoublyNode<string>)node).Prev.Value == "x");


            list.Add("z");

            Assert.IsTrue(list.Count == 3);

            node = list.Contains("x");
            Assert.IsTrue(node.Value == "x");
            Assert.IsTrue(node.Next.Value == "y");
            Assert.IsTrue(node.Next.Next.Value == "z");
            Assert.IsTrue(node.Next.Next.Next == null);
            Assert.IsTrue(((DoublyNode<string>)node).Prev == null);
            node = list.Contains("y");
            Assert.IsTrue(((DoublyNode<string>)node).Prev.Value == "x");
            node = list.Contains("z");
            Assert.IsTrue(((DoublyNode<string>)node).Prev.Value == "y");
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Node<string> node;
            var list = new DoublyLinkedList<string>();

            // add/dell one el
            list.Add("x");
            Assert.IsTrue(list.Count == 1);
            node = list.Contains("x");
            list.Delete(node);
            Assert.IsTrue(list.Count == 0);
            Assert.IsTrue(list.First == null);
            Assert.IsTrue(list.Last == null);

            // add two els, del first
            list.Add("x");
            list.Add("y");
            Assert.IsTrue(list.Count == 2);
            node = list.Contains("x");
            list.Delete(node);
            Assert.IsTrue(list.Count == 1);
            Assert.IsTrue(list.First.Value == "y");
            Assert.IsTrue(list.Last.Value == "y");

            node = list.Contains("y");
            list.Delete(node);
            Assert.IsTrue(list.Count == 0);

            // add two els, del last
            list.Add("x");
            list.Add("y");
            Assert.IsTrue(list.Count == 2);
            node = list.Contains("y");
            list.Delete(node);
            Assert.IsTrue(list.Count == 1);
            Assert.IsTrue(list.First.Value == "x");
            Assert.IsTrue(list.Last.Value == "x");

            node = list.Contains("x");
            list.Delete(node);
            Assert.IsTrue(list.Count == 0);


            // add three els, del middle
            list.Add("x");
            list.Add("y");
            list.Add("z");
            Assert.IsTrue(list.Count == 3);
            node = list.Contains("y");
            list.Delete(node);
            Assert.IsTrue(list.Count == 2);
            Assert.IsTrue(list.First.Value == "x");
            Assert.IsTrue(list.Last.Value == "z");

            // now 'x' has ref to 'z'
            Assert.IsTrue(list.First.Next.Value == "z");
        }
    }
}