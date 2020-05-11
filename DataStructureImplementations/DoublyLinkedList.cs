

namespace DataStructures
{
    public class DoublyLinkedList<E> : IList<E>
    {
        public int Count { get; set; }
        public DoublyLinkedListNode<E> Head { get; set; }
        public DoublyLinkedListNode<E> Tail { get; set; }

        public void Add(E data)
        {
            DoublyLinkedListNode<E> newNode = new DoublyLinkedListNode<E>(data);
            if (Head == null)
            {
                Head = Tail = newNode;
                Head.Previous = null;
                Head.Next = null;
                Count = 1;
            }
            else if (Head.Next == null)
            {
                Tail = newNode;
                Head.Next = Tail;
                Tail.Next = null;
                Tail.Previous = Head;
                Count = 2;
            }
            else
            {
                Tail.Next = newNode;
                newNode.Previous = Tail;
                newNode.Next = null;
                Tail = newNode;


                Count++;
            }


        }

        public void Remove(E data)
        {
            DoublyLinkedListNode<E> currentNode = Head;
            DoublyLinkedListNode<E> nextNode = Head.Next;
            if (Head == null)
            {
                throw new EmptyListException();
            }
            if (currentNode.Data.Equals(data))
            {
                Head = nextNode;
                Head.Previous = null;
                Count--;
            }
            else
            {
                while (nextNode != null)
                {
                    if (nextNode.Data.Equals(data))
                    {
                        currentNode.Next = nextNode.Next;
                        if (nextNode.Next != null)
                        {
                            nextNode.Next.Previous = currentNode;
                        }
                        else
                        {
                            Tail = currentNode; //make sure that if you remove the last node, you change Last prop
                        }
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
            DoublyLinkedListNode<E> currentNode = Head;
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