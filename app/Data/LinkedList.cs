using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Xml;

namespace Data
{

    public abstract class LinkedList<T> : ILinkedList<T>
    {
        internal Node<T> first;
        internal Node<T> last;
        protected internal int _count;
        public int Count => _count;
        public Node<T> First => first;
        public Node<T> Last => last;

        public abstract Node<T> Add(T item);
        public abstract void Delete(Node<T> n);

        public Node<T> Contains(T value)
        {
            if (first == null)
            {
                return null;
            }
            Node<T> node = first;
            do
            {
                if (EqualityComparer<T>.Default.Equals(node.item, value))
                {
                    return node;
                }
                node = node.next;
            }
            while (node != null);
            return null;
        }
        public T[] ToArray()
        {
            var arr = new T[_count];
            int i = 0;
            var node = first;
            while (node != null)
            {
                arr[i] = node.item;
                node = node.next;
                i++;
            }
            return arr;
        }
    }
}
