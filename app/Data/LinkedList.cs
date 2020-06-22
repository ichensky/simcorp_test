using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Xml;

namespace Data
{
    public class Node<T> {
        internal SinglyLinkedList<T> List;
        internal Node<T> Next;
        //public Node<T> Prev;
        public T Item;
        
        public Node(T item) {
            Item = item;
        }
        internal Node(SinglyLinkedList<T> list, T item) => (List, Item) = (list, item);
    }
   
    public class SinglyLinkedList<T>
    {
        public Node<T> first;
        public Node<T> last;

        public Node<T> Add(T item)
        {
            var node = new Node<T>(this,item);
            if (last==null)
            {
                first = node;
                last = node;
                return last;
            }

            last.Next = node;
            last = node;
            return node;
        }

        public Node<T> Contains(T value) {
            if (first==null)
            {
                return null;
            }
            Node<T> node = first;
            do
            {
                if (EqualityComparer<T>.Default.Equals(node.Item, value))
                {
                    return node;
                }
                node = node.Next;
            }
            while (node != null);
            return null;
        }
        public void Delete(Node<T> n)
        {
            ValidateNode(n);
            Node<T> node = first;
            Node<T> prev = null;
            do
            {
                if (node == n)
                {
                    break;
                }
                prev = node;
                node = node.Next;
            }
            while (node != null);
            if (prev == null)
            {
                first = first.Next;
            }
            else {
                prev.Next = n.Next;
                if (n.Next==null)
                {
                    last = prev;
                }
            }
        }


        internal void ValidateNode(Node<T> node)
        {
            if (node == null)
            {
                throw new ArgumentNullException(nameof(node));
            }

            if (node.List != this)
            {
                throw new InvalidOperationException("Externale linked list node.");
            }
        }
    }
}
