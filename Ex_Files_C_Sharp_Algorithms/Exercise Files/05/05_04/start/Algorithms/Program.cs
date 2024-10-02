using System;
using System.Collections.Generic;

namespace Algorithms {
    class Program {

        static void Main(string[] args) {
            int[] a = {8, 3, 6, 23, 6, 3, 6, 57, 78, 3};
            DisplayFrequenceOfEachElement(a);
        }

        static void DisplayFrequenceOfEachElement (int[] numbers) 
        {
            Dictionary<int, int> dict = new();

            foreach (int num in numbers) 
            {
                if (dict.ContainsKey(num)) 
                    dict[num]++;
                else 
                    dict.Add(num, 1);
            }

            foreach (int key in dict.Keys) 
            {
                Console.WriteLine("Number: {0}, Frequency: {1}", key, dict[key]);
            }
        }
    }
}