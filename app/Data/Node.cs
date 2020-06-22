using System.Threading.Tasks;

namespace Data
{
    public class Node<T> {
        internal ILinkedList<T> list;
        internal Node<T> next;
        internal T item;

        public Node<T> Next => next;
        public T Value => item;
        
        public Node(T item) {
            this.item = item;
        }
        internal Node(ILinkedList<T> list, T item) => (this.list, this.item) = (list, item);
    }
}
