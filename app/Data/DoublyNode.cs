namespace Data
{
    public class DoublyNode<T> : Node<T> { 
    
        internal Node<T> prev;
        public Node<T> Prev => prev;

        public DoublyNode(T item) : base(item) { }
        internal DoublyNode(ILinkedList<T> list, T item) : base(list, item) { }
    }
}
