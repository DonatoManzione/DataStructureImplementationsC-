

namespace DataStructures
{
    public class DoublyLinkedList<E> : IList<E>
    {
        public int Count { get; set; }
        public DoublyLinkedListNode<E> Head { get; set; }
        public DoublyLinkedListNode<E> Tail { get; set; }

        public void Add(E data)
        {
            DoublyLinkedListNode<E> newNode = new DoublyLinkedListNode<E>(data);
            if (Head == null)
            {
                //if there are no nodes yet, the tail and head will be the same, and their pointers will be null
                Head = Tail = newNode;
                Head.Previous = null;
                Head.Next = null;
                Count = 1;
            }
         
            else
            {
               
                Tail.Next = newNode; //add new Next pointer to current Tail
                newNode.Previous = Tail;//make current Tail the new node's Previous pointer
                newNode.Next = null; //make the new node's Next pointer null, as it will become the new Tail
                Tail = newNode; //Make newnode the new Tail
                Count++;//Add to count
            }


        }

        public void Remove(E data)
        {
            DoublyLinkedListNode<E> currentNode = Head;
            DoublyLinkedListNode<E> nextNode = Head.Next;
            if (Head == null)
            {
                throw new EmptyListException();
            }
            if (Head.Data.Equals(data))//account for the possibility that the node you're looking for is the Head
            {
                Head = nextNode;//change Head to be the second node
                Head.Previous = null;//eliminate reference to the former Head
                Count--;//reduce Count value by one
            }
            else
            {
                while (nextNode != null)
                {
                    if (nextNode.Data.Equals(data))
                    {
                        currentNode.Next = nextNode.Next;//skip nextNode in currentNode's references
                        if (nextNode.Next != null)//if nextnode isn't the tail, then adjust Previous pointer of the node AFTER nextnode
                        {
                            nextNode.Next.Previous = currentNode;
                        }
                        else
                        {
                            Tail = currentNode; //make sure that if you remove the last node, you change Tail prop
                        }
                        Count--;
                        break;
                    }
                    else
                    {
                        currentNode = nextNode;
                        nextNode = currentNode.Next;
                       
                    }
                }

            }
        }

        public LinkedListNode<E> Find(E data)
        {
            DoublyLinkedListNode<E> currentNode = Head;
            while (currentNode != null)
            {
                if (currentNode.Data.Equals(data))
                {
                    return currentNode;
                }
                else
                {
                    currentNode = currentNode.Next;
                }

            }
            throw new NoSuchElementException();

        }

        public void Clear()
        {
            Count = 0;
            Head = null;
            Tail = null;
        }

        public override string ToString()
        {
            DoublyLinkedListNode<E> currentNode = Head;
            string output = "{ ";
            for (int i = 0; i < Count - 1; i++)
            {
                output += currentNode.Data + ", ";
                currentNode = currentNode.Next;
            }
            output += currentNode.Data + " }";
            return output;
        }

       
    }
    public class DoublyLinkedListNode<E> : LinkedListNode<E>
    {
        public new E Data { get; set; }
        public new DoublyLinkedListNode<E> Next { get; set; }
        public DoublyLinkedListNode<E> Previous { get; set; }

        public DoublyLinkedListNode(E data)
        {
            Data = data;
        }
    }

}