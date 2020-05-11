using System;
namespace DataStructures
{
    public class Stack<E>
    {
        LinkedList<E> InnerList { get; set; }

        
        public Stack()
        {
            InnerList = new LinkedList<E>();
        }

        



    }
}
