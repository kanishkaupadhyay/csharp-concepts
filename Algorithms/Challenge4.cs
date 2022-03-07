using System;

namespace Algorithms {

    class Challenge4 {

        class Node {
            public Node Left { get; set; }
            public Node Right { get; set; }
            public int Data { get; set; }
        }

        class BinarySearchTree {
            public static Boolean Contains(Node root, int value)
            {
                if(root == null)
                {
                    return false;
                }
                else if(value < root.Data)
                {
                    return Contains(root.Left, value);
                }
                else if(value > root.Data)
                {
                    return Contains(root.Right, value);
                }
                return true;
            }

            public static Node Insert(Node root, int value) {
                if (root == null) {
                    root = new Node();
                    root.Data = value;
                } else if (value < root.Data) {
                    root.Left = Insert(root.Left, value);
                } else if (value > root.Data) {
                    root.Right = Insert(root.Right, value);
                }

                return root;
            }
        }

        static void Main(string[] args) {
            Node rootNode = new Node();
            rootNode.Data = 4;

            BinarySearchTree.Insert(rootNode, 2);
            BinarySearchTree.Insert(rootNode, 3);
            BinarySearchTree.Insert(rootNode, 5);
            BinarySearchTree.Insert(rootNode, 6);
            BinarySearchTree.Insert(rootNode, 4);

            System.Console.WriteLine(BinarySearchTree.Contains(rootNode, 3));
            System.Console.WriteLine(BinarySearchTree.Contains(rootNode, 6));
            System.Console.WriteLine(BinarySearchTree.Contains(rootNode, 9));
        }
    }
}