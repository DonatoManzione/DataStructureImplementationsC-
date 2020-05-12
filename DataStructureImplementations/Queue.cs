using System;
namespace DataStructures
{
    public class Queue<E>
    {
        private DoublyLinkedList<E> InnerList { get; set; }
        public int Count { get { return InnerList.Count; } }
        public Queue()
        {
            InnerList = new DoublyLinkedList<E>();

        }
        public void Enqueue(E data)
        {

            DoublyLinkedListNode<E> newNode = new DoublyLinkedListNode<E>(data); 

            
            if (InnerList.Count == 0)
            {
                InnerList.Head = InnerList.Tail = newNode; 
                InnerList.Count = 1; 
            }

            
            else if (InnerList.Count == 1)
            {
                
                InnerList.Head = newNode;
                InnerList.Head.Next = InnerList.Tail; 
                InnerList.Tail.Previous = InnerList.Head; 
                InnerList.Count++;
            }
            else
            {
                DoublyLinkedListNode<E> temp = InnerList.Head; 
                InnerList.Head = newNode; 
                InnerList.Head.Next = temp; 
                temp.Previous = InnerList.Head; 
                InnerList.Head.Previous = null; 
                InnerList.Count++;
            }

        }

        internal bool IsEmpty()
        {
            return InnerList.IsEmpty();
        }

        public E Dequeue()
        {
            E tailNodeData = InnerList.Tail.Data;
            if (InnerList.Count == 0) 
            {
                throw new EmptyQueueException();
            }
            else if (InnerList.Count == 1)
            {
                InnerList.Head = null;
                InnerList.Tail = null;
                InnerList.Count = 0;

            }
            else
            {

                InnerList.Tail = InnerList.Tail.Previous; 
                InnerList.Tail.Next = null; 
                InnerList.Count--; 
            }
            return tailNodeData;

        }


        public E Peek()
        {
            return InnerList.Head.Data;
        }




        public override string ToString()
        {
            DoublyLinkedListNode<E> currentNode = InnerList.Tail;
            string output = "\n*********QUEUE***********\n";
            for (int i = 0; i < Count; i++)
            {
                output += "----( " + currentNode.Data + " )-";
                currentNode = currentNode.Previous;
            }
           
            output += "\n*********QUEUE***********\n";

            return output;

        }
    }
}
