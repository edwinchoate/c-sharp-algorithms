using System;

namespace Algorithms {

    class Program {

        class Node {
            public Node Left { get; set; }
            public Node Right { get; set; }
            public int Data { get; set; }
        }

        class BinaryTree {

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
        }
    }
}