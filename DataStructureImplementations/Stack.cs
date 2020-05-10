using System;
namespace DataStructures
{
    public class Stack<E>
    {
        DoublyLinkedList<E> InnerList { get; set; }

        
        public Stack()
        {
            InnerList = new DoublyLinkedList<E>();
        }



    }
}
