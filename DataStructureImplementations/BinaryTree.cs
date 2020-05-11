using System;
namespace DataStructures
{
    public class BinaryTree<E>
    {
        public BinaryTreeNode<E> RootNode { get; set; }
        public BinaryTree()
        {
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

        public void InsertNodeLeftmostPosition(BinaryTreeNode<E> parentNode, E data)
        {
            BinaryTreeNode<E> newNode = new BinaryTreeNode<E>(data);
            if (parentNode == null)
            {
                parentNode = newNode;
            }
            else if (parentNode.LeftChild == null)
            {
                parentNode.LeftChild = newNode;
            }else
            {
                InsertNodeLeftmostPosition(parentNode.LeftChild, data);
                
              
            }
            
        }
        public void InsertNodeRightmostPosition(BinaryTreeNode<E> parentNode, E data)
        {
            BinaryTreeNode<E> newNode = new BinaryTreeNode<E>(data);
            if (parentNode == null)
            {
                parentNode = newNode;
            }
            else if (parentNode.RightChild == null)
            {
                parentNode.RightChild = newNode;
            }
            else
            {
                InsertNodeRightmostPosition(parentNode.RightChild, data);


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
        public BinaryTreeNode<E> LeftChild { get; set; }
        public BinaryTreeNode<E> RightChild { get; set; }
    }
}
