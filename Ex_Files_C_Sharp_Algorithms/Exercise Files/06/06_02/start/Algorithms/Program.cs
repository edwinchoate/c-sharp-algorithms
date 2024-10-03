using System;
using Microsoft.VisualBasic;

namespace Algorithms {

    class Program {

        class Node
        {
            public Node LeftChild { get; set; }
            public Node RightChild { get; set; }
            public int Data { get; set; }
        }

        class BST 
        {
            private Node _root;

            public void Add (Node node)
            {
                if (_root == null) 
                    _root = node;
                else 
                {
                    Node current = _root;
                    Node next = _root;;

                    while (next != null) 
                    {
                        current = next;
                        if (node.Data <= current.Data) 
                            next = current.LeftChild;
                        else
                            next = current.RightChild;
                    }

                    if (node.Data < current.Data)
                        current.LeftChild = node;
                    else if (node.Data > current.Data)
                        current.RightChild = node;
                    // Duplicates are excluded
                }
            }

            public Node Find (Node node) 
            {
                Node current = _root;

                while (current != null) 
                {
                    if (node.Data <= current.Data)
                        current = current.LeftChild;
                    else 
                        current = current.RightChild;
                }

                if (current == null) 
                    return null;
                else 
                    return current;
            }

            public void Remove (Node node) 
            {
                Node parent = _root;

                while (parent.LeftChild.Data != node.Data || parent.RightChild.Data != node.Data) 
                {
                    if (node.Data <= parent.Data)
                        parent = parent.LeftChild;
                    else 
                        parent = parent.RightChild;
                }

                if (node.Data <= parent.Data)
                    parent.LeftChild = null;
                else 
                    parent.RightChild = null;
            }

        }

        static void Main(string[] args) {
            Node node1 = new Node();
            Node node2 = new Node();
            Node node3 = new Node();
            Node node4 = new Node();
            Node node5 = new Node();

            node1.Data = 2;
            node2.Data = 3;
            node3.Data = 5;
            node4.Data = 6;
            node5.Data = 4;

            BST bst = new BST();

            bst.Add(node1);
            bst.Add(node2);
            bst.Add(node3);
            bst.Add(node4);
            bst.Add(node5);
        }
    }
}