using System;

namespace Algorithms {
    class Program {
        static void RotateArrayLeft (int[] numbers)
        {
            if (numbers == null || numbers.Length <= 1)
                return;

            int temp = numbers[0];

            for (int i = 0; i < numbers.Length - 1; i++) 
            {
                numbers[i] = numbers[i+1];
            }

            numbers[numbers.Length - 1] = temp;
        }

        static void Main(string[] args) {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            RotateArrayLeft(arr);
            Array.ForEach(arr, Console.WriteLine);
        }
    }
}