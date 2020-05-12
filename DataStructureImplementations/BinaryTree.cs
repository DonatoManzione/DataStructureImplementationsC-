using System;
namespace DataStructures
{
    public class BinaryTree<E>
    {
        public BinaryTreeNode<E> RootNode { get; set; }
        public BinaryTreeNode<E> BottommostNode { get; set; }
       
        public BinaryTree()
        {
        }










        public void Insert(E data)
        {
            BinaryTreeNode<E> newNode = new BinaryTreeNode<E>(data);

            if(RootNode == null)
            {
                RootNode = newNode;
                return;
            }



            Queue<BinaryTreeNode<E>> myQueue = new Queue<BinaryTreeNode<E>>();

            myQueue.Enqueue(RootNode);

            while (!myQueue.IsEmpty())
            {
                BinaryTreeNode<E> temp = myQueue.Dequeue();

                if (temp.LeftChild == null)
                {
                    temp.LeftChild = newNode;
                    break;
                }else
                {
                    myQueue.Enqueue(temp.LeftChild);
                }

                if(temp.RightChild == null)
                {
                    temp.RightChild = newNode;
                    break;
                }else
                {
                    myQueue.Enqueue(temp.RightChild);
                }
            }

        }







        public void PreOrderTraversal(BinaryTreeNode<E> node)
        {
            if (node != null)
            {
                Print(node);
                PreOrderTraversal(node.LeftChild);
                PreOrderTraversal(node.RightChild);
            }
        }
        public void InOrderTraversal(BinaryTreeNode<E> node)
        {
            if (node != null)
            {
               
                InOrderTraversal(node.LeftChild);
                Print(node);
                InOrderTraversal(node.RightChild);
            }
        }
        public void PostOrderTraversal(BinaryTreeNode<E> node)
        {
            if (node != null)
            {

                PostOrderTraversal(node.LeftChild);
                PostOrderTraversal(node.RightChild);
                Print(node);
            }
        }

             
       

        public void Print(BinaryTreeNode<E> node)
        {
            Console.WriteLine(node.Data);
            
        }

        
    }
    public class BinaryTreeNode<E>
    {
        

        public BinaryTreeNode(E data)
        {
            this.Data = data;
        }

        public E Data { get; set; }
        public BinaryTreeNode<E> Parent { get; set; }
        public BinaryTreeNode<E> LeftChild { get; set; }
        public BinaryTreeNode<E> RightChild { get; set; }
    }
}
