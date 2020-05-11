using System;
namespace DataStructures
{
    public class Stack<E>
    {
        private DoublyLinkedList<E> InnerList { get; set; }
        public int Count { get; set; }

        public Stack()
        {
            InnerList = new DoublyLinkedList<E>();
            Count = 0;
        }

        public void Push(E data)
        {
            InnerList.Add(data);
            Count++;
        }

        public E Pop()
        {
            
            if (Count == 0)
            {
                throw new EmptyStackException();
            }
            else
            {
                InnerList.Count = Count = Count - 1;
                E returnVal = InnerList.Tail.Data;

                if (InnerList.Tail.Previous != null)
                {
                    InnerList.Tail = InnerList.Tail.Previous;
                    InnerList.Tail.Next = null;
                }
                else
                {
                    InnerList.Tail = null;
                    InnerList.Head = null;

                }

                return returnVal;
            }

        }



    }
}
