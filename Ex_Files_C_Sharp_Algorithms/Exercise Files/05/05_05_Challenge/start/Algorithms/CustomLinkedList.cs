﻿using System;
using System.Collections.Generic;

namespace Algorithms {
    class CustomLinkedList {
        Node head;

         public class Node {
            public int data;
            public Node next;

            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        public Boolean hasCycle() {
            Node current = head;
            HashSet<Node> nodes = new();

            while (current.next != null)
            {
                if (!nodes.Contains(current))
                    nodes.Add(current);
                else 
                    return true;
                current = current.next;
            }

            return false;
        }

        static void Main(string[] args) {
            CustomLinkedList noCycleLinkedList = new CustomLinkedList();
            Node firstNode = new Node(3);
            Node secondNode = new Node(4);
            Node thirdNode = new Node(5);
            Node fourthNode = new Node(6);

            noCycleLinkedList.head = firstNode;
            firstNode.next = secondNode;
            secondNode.next = thirdNode;
            thirdNode.next = fourthNode;

            Console.WriteLine(noCycleLinkedList.hasCycle());

            CustomLinkedList cycleLinkedList = new CustomLinkedList();
            cycleLinkedList.head = firstNode;
            thirdNode.next = secondNode;

            Console.WriteLine(cycleLinkedList.hasCycle());
        }
    }
}