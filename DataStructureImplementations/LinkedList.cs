using System;
namespace DataStructures
{
    public class LinkedList<E> : IList<E>
    {
        public LinkedListNode<E> First { get; set; }
        public LinkedListNode<E> Last { get; set; }
        public int Count { get; set; }

        public void AddLast(E data)
        {
            LinkedListNode<E> newNode = new LinkedListNode<E>(data);
            if (First == null)
            {
                First = Last = newNode;
                First.Next = null;
                Count = 1;
            }
            else if (First.Next == null)
            {
                Last = newNode;
                First.Next = Last;
                Last.Next = null;
                Count = 2;
            }
            else
            {
                Last.Next = newNode;
                Last = newNode;
                Last.Next = null;
                Count++;
            }


        }

        public void AddFirst(E data)
        {
            LinkedListNode<E> newNode = new LinkedListNode<E>(data);
            if (First == null)
            {
                First = Last = new LinkedListNode<E>(data);
                First.Next = null;
                Count = 1;
            }
            else
            {
                LinkedListNode<E> temp = First;
                First = newNode;
                First.Next = temp;
                Count++;
            }



        }

        public void Remove(E data)
        {
            LinkedListNode<E> currentNode = First;
            LinkedListNode<E> nextNode = First.Next;

            if (First == null)
            {
                throw new EmptyListException();
            }
            if (currentNode.Data.Equals(data))
            {
                First = nextNode;
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
            if (First == null)
            {
                throw new EmptyListException();
            }
            else
            {
                LinkedListNode<E> currentNode = First;
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
