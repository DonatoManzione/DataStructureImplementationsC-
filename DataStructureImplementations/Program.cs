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

            Stack<string> myStack = new Stack<string>();
            myStack.Push("FIRST STACK EL");
            myStack.Push("SECOND STACK EL");
            myStack.Push("THIRD STACK EL");
            while (myStack.Count > 0){
                Console.WriteLine(myStack.Pop());
            }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }

            BinaryTree<int> tree = new BinaryTree<int>();
            tree.RootNode = new BinaryTreeNode<int>(1);
            tree.RootNode.LeftChild = new BinaryTreeNode<int>(2);
            tree.RootNode.RightChild = new BinaryTreeNode<int>(3);
            tree.RootNode.LeftChild.LeftChild = new BinaryTreeNode<int>(4);
            tree.RootNode.LeftChild.RightChild = new BinaryTreeNode<int>(5);
            tree.RootNode.RightChild.LeftChild = new BinaryTreeNode<int>(6);
            tree.RootNode.RightChild.RightChild = new BinaryTreeNode<int>(7);
            tree.PostOrderTraversal(tree.RootNode);


        }

        static void PrintList(LinkedList<string> list)
        {
            LinkedListNode<string> currentNode = list.Head;
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
            DoublyLinkedListNode<string> currentNode = list.Head;
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
            DoublyLinkedListNode<string> currentNode = list.Tail;
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
