using System;
using System.Collections.Generic;

namespace Algorithms {
    class Program {
        static void Main(string[] args) {

            Queue<int> queue = new();

            queue.Enqueue(1);
            queue.Enqueue(8);
            queue.Enqueue(4);
            queue.Enqueue(7);
            queue.Enqueue(3);
            queue.Enqueue(9);

            int front = queue.Dequeue();
            Console.WriteLine(front);

            front = queue.Dequeue();
            Console.WriteLine(front);

            front = queue.Peek();
            Console.WriteLine(front);

            front = queue.Dequeue();
            Console.WriteLine(front);

            int current;
            while (queue.TryDequeue(out current)) 
            {
                Console.WriteLine(current);
            }

        }
    }
}