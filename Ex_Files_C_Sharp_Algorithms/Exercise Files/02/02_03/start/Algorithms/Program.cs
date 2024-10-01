using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms {
    class Program {
        static int[] FindEvenNums(int[] arr1, int[] arr2) {
            List<int> list = new();

            list.AddRange(arr1.Where(IsEven));
            list.AddRange(arr2.Where(IsEven));

            return list.ToArray();
        }

        static bool IsEven(int i)
        {
            return i % 2 == 0;
        }

        static void Main(string[] args) {
            int[] arr1 = {-8, 2, 3, -9, 11, -20};
            int[] arr2 = {0, -2, -9, -39, 39, 10, 7};

            int[] evenArr = FindEvenNums(arr1, arr2);

            Array.ForEach(evenArr, Console.WriteLine);
        }
    }
}