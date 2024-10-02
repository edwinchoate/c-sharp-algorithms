using System;
using System.Collections.Generic;

namespace Algorithms {
    class Program {
        static void printNextGreaterElement(int[] arr) {
            if (arr == null || arr.Length == 0) 
            {
                Console.WriteLine();
                return;
            }

            Stack<int> stack = new();
            stack.Push(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                int item = arr[i];

                if (stack.Count == 0)
                    stack.Push(item);
                else 
                {
                    int popped = stack.Pop();

                    while (popped < item) 
                    {
                        Console.WriteLine(popped + "-->" + item);
                        if (stack.Count == 0) break;
                        popped = stack.Pop();
                    }

                    if (popped > item)
                        stack.Push(popped);
                    
                    stack.Push(item);
                } 
            }

            while (stack.Count > 0) 
            {
                Console.WriteLine(stack.Pop() + "-->-1");
            }
        }

        static void Main(string[] args) {
            int[] arr = new int[] {15, 8, 4, 10};
            int[] arr2 = new int[] {2};
            int[] arr3 = new int[] {2, 3};
            int[] arr4 = new int[] {};

            printNextGreaterElement(arr);
            printNextGreaterElement(arr2);
            printNextGreaterElement(arr3);
            printNextGreaterElement(arr4);
        }
    }
}