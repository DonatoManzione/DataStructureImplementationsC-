using System;
namespace DataStructures
{
    public class Stack<E>
    {
        private DoublyLinkedList<E> InnerList { get; set; }
        public int Count { get { return InnerList.Count; }  }

        public Stack()
        {
            InnerList = new DoublyLinkedList<E>();
          
        }

        public void Push(E data)
        {
            InnerList.Add(data);
            
        }

        public E Pop()
        {

            if (Count == 0)
            {
                throw new EmptyStackException();
            }
            else
            {
                InnerList.Count--; 
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

        public override string ToString()
        {
            DoublyLinkedListNode<E> currentNode = InnerList.Tail;
            string output = "\n*********STACK***********\n";
            for (int i = 0; i < Count; i++)
            {
                output += "( "+currentNode.Data + " )\n";
                currentNode = currentNode.Previous;
            }
            output+= "*********STACK***********\n"; 

            return output;

        }

        public bool IsEmpty()
        {
            return Count == 0;
        }
    }
}
