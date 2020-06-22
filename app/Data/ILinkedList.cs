using System;

namespace Data
{
    public interface ILinkedList<T> {
        int Count { get; }

        Node<T> Add(T item);
        Node<T> Contains(T value);
        void Delete(Node<T> n);
        T[] ToArray();

        internal void ValidateNode(Node<T> node)
        {
            if (node == null)
            {
                throw new ArgumentNullException(nameof(node));
            }

            if (node.list != this)
            {
                throw new InvalidOperationException("Externale linked list node.");
            }
        }
    }
}
