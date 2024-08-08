using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Trees
{
    public class BinarySearchTree
    {
        private Node<int>? Root;
        private int Count = 0;
        
        public void Insert(int data)
        {
            Node<int> newNode = new Node<int>(data);
            InsertHelper(newNode, Root);


        }
        private void InsertHelper(Node<int> newNode, Node<int>? currentNode)
        {
            if (Root == null)
            {
                Root = newNode;
                Count++;
                return;
            }
            if (newNode.Data <= currentNode.Data) // go left
            {
                if (currentNode.Left == null)
                {
                    currentNode.Left = newNode;
                    Count++;
                }
                else
                {
                    InsertHelper(newNode, currentNode.Left);
                }
            }
            else // go right
            {
                if (currentNode.Right == null)
                {
                    currentNode.Right = newNode;
                    Count++;
                }
                else
                {
                    InsertHelper(newNode, currentNode.Right);
                }
            }
        }
        public bool DoesValueExist(int value)
        {
            Node<int>? currentNode = Root;

            while (currentNode != null)
            {
                if (currentNode.Data == value) return true;
                else if (value <= currentNode.Data)
                {
                    currentNode = currentNode.Left;
                }else
                {
                    currentNode = currentNode.Right;
                }
            }
            return false;
        }

    }
}
