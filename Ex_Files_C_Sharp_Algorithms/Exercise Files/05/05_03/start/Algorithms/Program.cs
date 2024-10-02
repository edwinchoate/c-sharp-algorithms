using System;
using System.Collections.Generic;

namespace Algorithms {
    class Program {

        static void Main(string[] args)
        {
            int[] a = {3, 2, 8, 4, 5};
            int[] b = {5, 7, 3, 0, 2};

            foreach (int num in FindMissingElements(a, b)) 
            {
                Console.WriteLine(num);
            }
        }

        static List<int> FindMissingElements (int[] array1, int[] array2) 
        {
            HashSet<int> hashset = new();
            List<int> missingElements = new();
            
            foreach (int num in array2) 
            {
                hashset.Add(num);
            }

            foreach (int num in array1) 
            {
                if (!hashset.Contains(num))
                    missingElements.Add(num);
            }

            return missingElements;
        }
    }
}