using System;
using System.Collections.Generic;

namespace Algorithms {
    class Program {
        static void Main(string[] args) {

            PrintBinary(50);

        }

        static void PrintBinary (int n) 
        {
            if (n <= 0) return;

            Queue<int> queue = new();
            queue.Enqueue(1);

            for (int i = 0; i < n; i++) 
            {
                int current = queue.Dequeue();
                Console.WriteLine(current);

                queue.Enqueue(current*10);
                queue.Enqueue(current*10 + 1);
            }
        } 
    }
}