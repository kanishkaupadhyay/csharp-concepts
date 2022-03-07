using System;

namespace Algorithms
{
    class AnotherLinkedList
    {
        Node head;

        class Node
        {
            public char data;
            public Node next;
            public Node(char d)
            {
                data = d;
            }
        }

        public void display()
        {
            Node current = head;
            while(current != null)
            {
                System.Console.Write(current.data + " | ");
                current = current.next;
            }
            System.Console.WriteLine();
        }
        static void Main(string[] args)
        {
            AnotherLinkedList mylist = new AnotherLinkedList();
            Node a = new Node('A');
            Node b = new Node('B');
            Node c = new Node('C');
            Node d = new Node('D');
            Node e = new Node('E');
            mylist.head = a;
            a.next = b;
            b.next = c;
            c.next = d;
            d.next = e;

            // display
            mylist.display();
        }
    }
}