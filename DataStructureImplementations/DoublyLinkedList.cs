

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
                First.Previous = null;
                First.Next = null;
                Count = 1;
            }
            else if (First.Next == null)
            {
                Last = newNode;
                First.Next = Last;
                Last.Next = null;
                Last.Previous = First;
                Count = 2;
            }
            else
            {
                Last.Next = newNode;
                newNode.Previous = Last;
                Last = newNode;
                Last.Next = null;
                
                Count++;
            }


        }

        public void AddFirst(E data)
        {
            DoublyLinkedListNode<E> newNode = new DoublyLinkedListNode<E>(data);
            if (First == null)
            {
                First = Last = new DoublyLinkedListNode<E>(data);
                First.Next = null;
                Count = 1;
            }
            else
            {
                DoublyLinkedListNode<E> temp = First;
                First = newNode;
                First.Next = temp;
                First.Previous = null;
                Count++;
            }



        }

        

        public void Remove(E data)
        {

            DoublyLinkedListNode<E> currentNode = First;
            DoublyLinkedListNode<E> nextNode = First.Next;

            if (First == null)
            {
                throw new EmptyListException();
            }
            if (currentNode.Data.Equals(data))
            {
                First = nextNode;
                First.Previous = null;
                Count--;
            }
            else
            {
                while (nextNode != null)
                {
                    if (nextNode.Data.Equals(data))
                    {

                        currentNode.Next = nextNode.Next;
                        nextNode.Previous = currentNode.Previous;

                        Count--;
                        break;
                    }
                    else
                    {
                        currentNode = nextNode;
                        nextNode = currentNode.Next;
                    }
                }

            }
        }







        public LinkedListNode<E> Find(E data)
        {
            DoublyLinkedListNode<E> currentNode = First;
            while (currentNode != null)
            {
                if (currentNode.Data.Equals(data))
                {
                    return currentNode;
                }
                else
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