using System;

namespace Algorithms {
    class Program {
        // static int[] Reverse (int[] input) 
        // {
        //     int[] reversed = new int[input.Length];

        //     for (int i = 0; i < input.Length; i++) 
        //     {
        //         reversed[i] = input[(input.Length - 1) - i];
        //     }

        //     return reversed;
        // }

        static int[] Reverse (int[] input) 
        {
            int[] reversed = new int[input.Length];

            for (int i = 0, j = input.Length - 1; i < input.Length && j >= 0; i++, j--) 
            {
                reversed[i] = input[j];
            }

            return reversed;
        }

        // static int[] ReverseInPlace(int[] input) {
        //     Array.Sort(input, (x, y) => y.CompareTo(x));
        //     return input;
        // }

        static void ReverseInPlace (int[] arr) 
        {
            for (int i = 0; i < arr.Length / 2; i++) 
            {
                int temp = arr[i];
                arr[i] = arr[(arr.Length - 1) - i];
                arr[(arr.Length - 1) - i] = temp;
            }
        }

        static void Main(string[] args) {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Array.ForEach(Reverse(arr), Console.WriteLine); 

            Array.ForEach(arr, Console.WriteLine);
            ReverseInPlace(arr);
            Array.ForEach(arr, Console.WriteLine);
        }
    }
}