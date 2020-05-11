using System;
namespace DataStructures
{
    public class LinkedList<E> : IList<E>
    {
        public LinkedListNode<E> Head { get; set; }
        public LinkedListNode<E> Tail { get; set; }
        public int Count { get; set; }


        public void Add(E data)
        {
            LinkedListNode<E> newNode = new LinkedListNode<E>(data);
            if (Head == null)
            {
                Head = Tail = newNode;
                Head.Next = null;
                Count = 1;
            }
            else if (Head.Next == null)
            {
                Tail = newNode;
                Head.Next = Tail;
                Tail.Next = null;
                Count = 2;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
                Tail.Next = null;
                Count++;
            }

        }

        public void Remove(E data)
        {
            LinkedListNode<E> currentNode = Head;
            LinkedListNode<E> nextNode = Head.Next;

            if (Head == null)
            {
                throw new EmptyListException();
            }
            if (currentNode.Data.Equals(data))
            {
                Head = nextNode;
                Count--;
            }
            else
            {
                while (nextNode != null)
                {
                    if (nextNode.Data.Equals(data))
                    {
                        currentNode.Next = nextNode.Next;
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
            if (Head == null)
            {
                throw new EmptyListException();
            }
            else
            {
                LinkedListNode<E> currentNode = Head;
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


    }
    public class LinkedListNode<E>
    {
        public LinkedListNode<E> Next { get; set; }
        public E Data { get; set; }


        public LinkedListNode(E Data)
        {
            this.Data = Data;
        }
        public LinkedListNode()
        {

        }
    }
}
