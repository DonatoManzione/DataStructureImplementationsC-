using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            
            LinkedList<string> myList = new LinkedList<string>();
            myList.AddFirst("HELLO");
            myList.AddFirst("Donato");
            
            Console.WriteLine(myList.Find("HELLO").Data);

            PrintListForward(myList);

            DoublyLinkedList<string> myList2 = new DoublyLinkedList<string>();
            myList2.AddFirst("Print");
            myList2.AddFirst("This");
            myList2.AddFirst("Backward");
            myList2.AddFirst("But not this");
            myList2.Remove("But not this");
            myList2.Remove("Backward");

            PrintListForward(myList2);



        }

        static void PrintListForward(LinkedList<string> list)
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

        static void PrintListForward(DoublyLinkedList<string> list)
        {
            DoublyLinkedListNode<string> currentNode = list.First;
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
