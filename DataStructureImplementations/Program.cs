using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            
            LinkedList<string> myList = new LinkedList<string>();
            myList.AddLast("HELLO");
            myList.AddLast("Donato");
            myList.AddLast("Developer");
            myList.Remove("HELLO");
            


            PrintListForward(myList);

            DoublyLinkedList<string> myList2 = new DoublyLinkedList<string>();
            myList2.AddLast("Print");
            myList2.AddLast("This");
            myList2.AddLast("Backward");
            myList2.AddLast("But not this");
            myList2.Remove("But not this");
            

            PrintListBackward(myList2);



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
        static void PrintListBackward(DoublyLinkedList<string> list)
        {
            DoublyLinkedListNode<string> currentNode = list.Last;
            if (currentNode == null)
            {
                throw new EmptyListException();
            }
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Data);
                currentNode = currentNode.Previous;
            }

        }

    }

    
}
