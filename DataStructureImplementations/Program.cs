using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.LinkedList<string> sampleList = new System.Collections.Generic.LinkedList<string>();
            
            LinkedList<string> myList = new LinkedList<string>();
            myList.AddLast("HELLO");
            
            myList.AddLast("Donato");
            
            myList.Remove("Donato");

            Console.WriteLine(myList.Find("HELLO").Data);
            myList.Find("Donato");
            PrintList(myList);



            
        }

        static void PrintList(LinkedList<string> list)
        {
            LinkedListNode<string> currentNode = list.First;
            if (currentNode == null)
            {
                throw new EmptyListException();
            }
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Data);
                currentNode = currentNode.Next;
            }

        }

       
    }

    
}
