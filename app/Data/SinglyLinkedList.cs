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
            if (_count==0)
            {
                throw new System.Exception("The LinkedList node does not belong to current LinkedList.");
            }
            Node<T> nodeToDel = first;
            Node<T> prev = null;
            var isExists = false;
            do
            {
                if (nodeToDel == node)
                {
                    isExists = true;
                    break;
                }
                prev = nodeToDel;
                nodeToDel = nodeToDel.next;
            }
            while (nodeToDel != null);
            if (!isExists)
            {
                throw new System.Exception("The LinkedList node does not belong to current LinkedList.");
            }
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
            _count--;
        }       
    }
}
