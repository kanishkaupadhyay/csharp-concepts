using System;

namespace Algorithms
{
    class Program12
    {
        class Node
        {
            public Node Left {get; set;}
            public Node Right {get; set;}
            public int Data {get; set;}

        }
        
        class BinarySearchTree
        {
            public static Node Insert(Node root, int value)
            {
                if(root == null)
                {
                    root = new Node();
                    root.Data = value;
                    return root;
                }
                else
                {
                    if(value < root.Data)
                    {
                        // insert on left
                        root.Left = Insert(root.Left, value);
                    }
                    else if (value > root.Data)
                    {
                        // insert on the rght side of the tree
                        root.Right = Insert(root.Right, value);
                    }
                }
                return root;
            }
        }
        static void Main(string[] args)
        {
            Node rootNode = new Node();
            rootNode.Data = 8;
            BinarySearchTree.Insert(rootNode, 4);
            BinarySearchTree.Insert(rootNode, 2);
            BinarySearchTree.Insert(rootNode, 10);
            BinarySearchTree.Insert(rootNode, 12);
        }
    }
}