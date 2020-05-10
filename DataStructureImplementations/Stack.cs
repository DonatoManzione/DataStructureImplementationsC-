using System;
namespace DataStructures
{
    public class Stack<E>
    {
        E[] InnerArray { get; set; }

        
        public Stack()
        {
            InnerArray = new E[10];
        }



    }
}
