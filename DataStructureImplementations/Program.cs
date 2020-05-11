using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList<string> myList = new LinkedList<string>();
            myList.Add("HELLO");
            myList.Add("Donato");
            myList.Add("Developer");
            myList.Remove("Developer");
            PrintList(myList);

            DoublyLinkedList<string> myList2 = new DoublyLinkedList<string>();
            myList2.Add("Print");
            myList2.Add("This");
            myList2.Add("Backward");
            myList2.Add("But not this");
            myList2.Remove("But not this");


            PrintListBackward(myList2);



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

        static void PrintList(DoublyLinkedList<string> list)
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
