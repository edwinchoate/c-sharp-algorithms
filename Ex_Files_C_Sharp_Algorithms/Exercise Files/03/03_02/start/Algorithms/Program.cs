using System;
using System.Collections.Generic;

namespace Algorithms {
    class Program {

        static void Main(string[] args) {
            LinkedList<string> list = new();

            list.AddLast("one");
            list.AddLast("two");
            list.AddLast("three");

            Console.WriteLine(list.Contains("two"));
            Console.WriteLine(list.Count);

            list.Remove("two");

            foreach (string item in list) 
            {
                Console.WriteLine(item);
            }
        }
    }
}