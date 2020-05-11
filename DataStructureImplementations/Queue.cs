using System;
namespace DataStructures
{
    public class Queue<E>
    {
        private DoublyLinkedList<E> InnerList { get; set; }
        public int Count { get; set; }
        public Queue()
        {
            InnerList = new DoublyLinkedList<E>();
            Count = 0;
        }
        public void Enqueue(E data)
        {
            DoublyLinkedListNode<E> newNode = new DoublyLinkedListNode<E>(data);
            if (InnerList.First == null)
            {
                InnerList.First = InnerList.Last = new DoublyLinkedListNode<E>(data);
                InnerList.First.Next = null;
                Count = 1;
            }
            else if (InnerList.First.Next == null)
            {
                InnerList.Last = newNode;
                InnerList.First.Next = InnerList.Last;
                InnerList.Last.Next = null;
                InnerList.Last.Previous = InnerList.First;
                Count = 2;
            }
            else
            {
                DoublyLinkedListNode<E> temp = InnerList.First;
                InnerList.First = newNode;
                InnerList.First.Next = temp;
                InnerList.First.Previous = null;
                Count++;
            }



        }
        public void Dequeue(E data)
        {


        }
    }
}
