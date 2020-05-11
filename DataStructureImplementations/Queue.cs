using System;
namespace DataStructures
{
    public class Queue<E>
    {
        private DoublyLinkedList<E> InnerList { get; set; }
        public int Count { get { return InnerList.Count; } }
        public Queue()
        {
            InnerList = new DoublyLinkedList<E>();

        }
        public void Enqueue(E data)
        {

            DoublyLinkedListNode<E> newNode = new DoublyLinkedListNode<E>(data); //Create new node from data

            //Account for when there are no elements in the list yet
            //head is null, tail is null, count is 0...
            if (InnerList.Count == 0)
            {
                InnerList.Head = InnerList.Tail = newNode; //...in that case, the head and tail node will be the same: the new node
                InnerList.Count = 1; //add 1 to the count variable
            }

            //Account for when there is only one element in the list
            //head and tail are the same, count is 1
            else if (InnerList.Count == 1)
            {
                //we are adding the element at the front of the list, so Head becomes our newNode
                InnerList.Head = newNode;
                //because we have more than one node now, the Next and Previous pointers can't point to null anymore
                InnerList.Head.Next = InnerList.Tail; //With only two nodes, the second is the tail, and we already had it set up
                InnerList.Tail.Previous = InnerList.Head; //adjust references -- Tail's Previous pointer should point to the head node
                InnerList.Count++;//add 1 to the count variable
            }
            else
            {
                DoublyLinkedListNode<E> temp = InnerList.Head; //Save the current head node in a temporary variable for later use
                InnerList.Head = newNode; // Make the new node the new head node
                InnerList.Head.Next = temp; //Make the old head node the new second node
                temp.Previous = InnerList.Head; //adjust references - Now temp's Previous is not null, but the new head
                InnerList.Head.Previous = null; //adjust references - Now newNode's Previous is null, as it is the head node
                InnerList.Count++;//adjust the count variable to account for one more node
            }

        }
        public E Dequeue()
        {
            E tailNodeData = InnerList.Tail.Data;//Put the tail node's data into a temporary variable to return later
            if (InnerList.Count == 0) //account for if the queue is empty
            {
                throw new EmptyQueueException();
            }
            else if (InnerList.Count == 1)//if there is only one element left, be sure to make both head and tail null
            {
                InnerList.Head = null;
                InnerList.Tail = null;
                InnerList.Count = 0;

            }
            else
            {

                InnerList.Tail = InnerList.Tail.Previous; //change Tail var so it will hold the former second-to-tail node
                InnerList.Tail.Next = null; //adjust references - Now the new Tail node's Next pointer will point to null
                InnerList.Count--; //adjust the count variable to account for one more node
            }
            return tailNodeData;

        }
        public override string ToString()
        {
            DoublyLinkedListNode<E> currentNode = InnerList.Tail;
            string output = "\n*********QUEUE***********\n";
            for (int i = 0; i < Count; i++)
            {
                output += "----( " + currentNode.Data + " )";
                currentNode = currentNode.Previous;
            }
           
            output += "\n*********QUEUE***********\n";

            return output;

        }
    }
}
