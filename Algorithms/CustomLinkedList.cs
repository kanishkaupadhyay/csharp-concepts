using System;

namespace Algorithms
{
    class CustomLinkedList
    {
        Node head;

        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
            }
        }
        public void deleteBackHalf()
        {
            if( head == null || head.next == null)
            {
                head = null;
            }
            Node slow = head;
            Node fast = head;
            Node prev = null;
            while(fast != null && fast.next != null)
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next.next;
            }

            prev.next = null;
        }
        public void displayContents()
        {
            Node current = head;
            while(current != null)
            {
                System.Console.Write(current.data + " -> ");
                current = current.next;
            }
            System.Console.WriteLine();
        }

        static void Main(string[] args)
        {
            CustomLinkedList ll = new CustomLinkedList();
            Node one = new Node(10);
            Node two = new Node(20);
            Node three = new Node(30);
            Node four = new Node(40);
            //  head to be the value of first node
            ll.head = one;
            // pointing to next node
            one.next = two;
            two.next = three;
            three.next = four;
            ll.displayContents();
            ll.deleteBackHalf();
            ll.displayContents();
        }
    }
}