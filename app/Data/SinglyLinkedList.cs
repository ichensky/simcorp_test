namespace Data
{
    public class SinglyLinkedList<T> : LinkedList<T>
    {
        public override Node<T> Add(T item)
        {
            _count++;
            var node = new Node<T>(this,item);
            if (last==null)
            {
                first = node;
                last = node;
                return last;
            }

            last.next = node;
            last = node;
            return node;
        }

        public override void Delete(Node<T> node)
        {
            ((ILinkedList<T>)this).ValidateNode(node);
            _count--;
            Node<T> nodeToDel = first;
            Node<T> prev = null;
            do
            {
                if (nodeToDel == node)
                {
                    break;
                }
                prev = nodeToDel;
                nodeToDel = nodeToDel.next;
            }
            while (nodeToDel != null);
            if (prev == null)
            {
                first = first.next;
                if (first==null)
                {
                    last = null;
                }
            }
            else {
                prev.next = nodeToDel.next;
                if (nodeToDel.next==null)
                {
                    last = prev;
                }
            }
        }       
    }
}
