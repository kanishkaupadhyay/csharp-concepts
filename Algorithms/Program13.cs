using System;

namespace Algorithms {

    class Program13 {

        class Node {
            public Node Left { get; set; }
            public Node Right { get; set; }
            public int Data { get; set; }
        }

        class BinaryTree {
            public static void PreOrderTraversal(Node root)
            {
                if(root == null)
                {
                    return;
                }
                System.Console.Write(root.Data + " ");
                PreOrderTraversal(root.Left);
                PreOrderTraversal(root.Right);
            }
            public static void PostOrderTraversal(Node root)
            {
                if(root == null)
                {
                    return;
                }
                PostOrderTraversal(root.Left);
                PostOrderTraversal(root.Right);
                System.Console.Write(root.Data + " ");
            }
            public static void InOrderTraversal(Node root)
            {
                if(root == null)
                {
                    return;
                }
                InOrderTraversal(root.Left);
                System.Console.Write(root.Data + " ");
                InOrderTraversal(root.Right);
            }
        }

        static void Main(string[] args) {

            //       4
            //    1     3
            //  8   9  6
            Node rootNode = new Node();
            rootNode.Data = 4;

            Node nodeOne = new Node();
            nodeOne.Data = 1;

            Node nodeThree = new Node();
            nodeThree.Data = 3;

            Node nodeEight = new Node();
            nodeEight.Data = 8;

            Node nodeNine = new Node();
            nodeNine.Data = 9;

            Node nodeSix = new Node();
            nodeSix.Data = 6;

            rootNode.Left = nodeOne;
            rootNode.Right = nodeThree;
            nodeOne.Left = nodeEight;
            nodeOne.Right = nodeNine;
            nodeThree.Left = nodeSix;

            BinaryTree.PreOrderTraversal(rootNode);
            System.Console.WriteLine();
            BinaryTree.PostOrderTraversal(rootNode);
            System.Console.WriteLine();
            BinaryTree.InOrderTraversal(rootNode);
        }
    }
}