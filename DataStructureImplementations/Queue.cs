//using System;
//namespace DataStructures
//{
//    public class Queue<E>
//    {
        
//        public Queue()
//        {
//        }
//        public void AddFirst(E data)
//        {
//            DoublyLinkedListNode<E> newNode = new DoublyLinkedListNode<E>(data);
//            if (First == null)
//            {
//                First = Last = new DoublyLinkedListNode<E>(data);
//                First.Next = null;
//                Count = 1;
//            }
//            else if (First.Next == null)
//            {
//                Last = newNode;
//                First.Next = Last;
//                Last.Next = null;
//                Last.Previous = First;
//                Count = 2;
//            }
//            else
//            {
//                DoublyLinkedListNode<E> temp = First;
//                First = newNode;
//                First.Next = temp;
//                First.Previous = null;
//                Count++;
//            }



//        }
//        public void RemoveLast(E data)
//        {
            

//        }
//    }
//}
