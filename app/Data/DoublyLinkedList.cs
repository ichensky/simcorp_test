namespace Data
{
    public class DoublyLinkedList<T> : LinkedList<T>
    {
        public override Node<T> Add(T item)
        {
            _count++;
            var node = new DoublyNode<T>(this, item);
            if (last == null)
            {
                first = node;
                last = node;
                return last;
            }

            last.next = node;
            node.prev = last;
            last = node;
            return node;
        }

        public override void Delete(Node<T> node)
        {
            ((ILinkedList<T>)this).ValidateNode(node);
            _count--;
            var n = node as DoublyNode<T>;
            Node<T> nodeToDel = first;
            do
            {
                if (nodeToDel == n)
                {
                    break;
                }
                nodeToDel = nodeToDel.next;
            }
            while (nodeToDel != null);
            if (n.prev == null)
            {
                first = first.next;
                if (first == null)
                {
                    last = null;
                }
                else { 
                    ((DoublyNode<T>)first).prev = null;
                }
            }
            else
            {
                n.prev.next = n.next;
                if (n.next == null)
                {
                    last = n.prev;
                }
            }
        }
    }
}
