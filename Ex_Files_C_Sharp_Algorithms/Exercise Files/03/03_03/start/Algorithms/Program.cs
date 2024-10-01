using System;

namespace Algorithms {
    class CustomLinkedList {

        Node head;

        public class Node {
            public int data;
            public Node next;

            public Node(int d) { data = d; }
        }

        // public void DeleteBackHalf () 
        // {
        //     int length = 0;
        //     Node current = head;

        //     while (current != null) 
        //     {
        //         length++;
        //         current = current.next;
        //     }

        //     int count = length / 2;
        //     current = head;

        //     while (count > 0)
        //     {
        //         current = current.next;
        //         count--;
        //     }

        //     current.next = null;
        // }

        public void DeleteBackHalf () 
        {
            if (head == null || head.next == null)
                head = null;

            Node slow = head, fast = head;

            while (fast.next != null) 
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            slow.next = null;
        }

        public void PrintList () 
        {
            Node current = head;

            while (current != null) 
            {
                Console.Write(current.data + "->");
                current = current.next;
            }
            Console.WriteLine();
        }

        static void Main(string[] args) {
            CustomLinkedList list = new();

            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);

            list.head = node1;
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;

            list.PrintList();

            list.DeleteBackHalf();

            list.PrintList();

        }
    }
}