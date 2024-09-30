using System;

namespace Algorithms {
    class Program {

        static int? LinearSearch(int[] input, int n) {
            foreach (int num in input) 
            {
                if (num == n) return n;
            }
            return null;
        }

        static void Main(string[] args) {
            int[] arr = {1, 2, 3, 4, 5, 6 };
            Console.WriteLine(LinearSearch(arr, 4));
            Console.WriteLine(LinearSearch(arr, 8));

            int evenNum = Array.Find(arr, (n) => n % 2 == 0);
            int[] evenNums = Array.FindAll(arr, (n) => n % 2 == 0);

            Array.ForEach(evenNums, Console.WriteLine);
        }
    }
}