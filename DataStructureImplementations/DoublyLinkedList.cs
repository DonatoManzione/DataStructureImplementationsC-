

namespace DataStructures
{
    public class DoublyLinkedList<E> : IList<E>
    {
        public int Count { get; set; }
        public DoublyLinkedListNode<E> First { get; set; }
        public DoublyLinkedListNode<E> Last { get; set; }

        public void AddLast(E data)
        {
            DoublyLinkedListNode<E> newNode = new DoublyLinkedListNode<E>(data);

            if (First == null)
            {
                First = Last = newNode;
                Last.Next = null;
                Last.Previous = null;
                Count = 1;
            }else
            {
                Last.Next = newNode;
                newNode.Previous = Last;
                Last = newNode;
                Count++;
            }
        }

        public void AddFirst(E data)

        {
            DoublyLinkedListNode<E> newNode = new DoublyLinkedListNode<E>(data);

            if (First == null)
            {
                First = newNode;
                First.Next = null;
                First.Previous = null;
                Count = 1;
            }else
            {
                First.Previous = newNode;
                newNode.Next = First;
                First = newNode;
                Count++;
            }
        }

        public void Remove(E data)
        {
            if (First == null)
            {
                throw new EmptyListException();
            }
            DoublyLinkedListNode<E> currentNode = First;
            while(currentNode != null)
            {
                if (currentNode.Data.Equals(data))
                {
                    currentNode.Previous.Next = currentNode.Next;
                    currentNode.Next.Previous = currentNode.Previous;
                    Count--;
                    return;
                }else
                {
                    currentNode = currentNode.Next;
                }
            }
            




        }

        public LinkedListNode<E> Find(E data)
        {
            DoublyLinkedListNode<E> currentNode = First;
            while(currentNode != null)
            {
                if (currentNode.Data.Equals(data))
                {
                    return currentNode;
                }else
                {
                    currentNode = currentNode.Next;
                }
                
            }
            throw new NoSuchElementException();
            
        }
    }
    public class DoublyLinkedListNode<E> : LinkedListNode<E>
        {
            public new E Data { get; set; }
            public new DoublyLinkedListNode<E> Next { get; set; }
            public DoublyLinkedListNode<E> Previous { get; set; }

            public DoublyLinkedListNode(E data)
            {
                Data = data;
        }
        }
    
}