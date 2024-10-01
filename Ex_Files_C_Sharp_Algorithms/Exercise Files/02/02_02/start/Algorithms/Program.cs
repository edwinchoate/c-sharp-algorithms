using System;

namespace Algorithms {
    class Program {

        static Boolean BinarySearch(int[] inputArray, int item) {
            if (inputArray == null || inputArray.Length == 0) 
                return false; 

            int i = 0, j = inputArray.Length - 1;
            int midpoint;

            while (i <= j) 
            {
                midpoint = (j + i) / 2;

                if (inputArray[midpoint] == item) 
                    return true;

                if (item < inputArray[midpoint])
                    j = midpoint - 1;
                else 
                    i = midpoint + 1;
            }

            return false;
        }

        static void Main(string[] args) {
            int[] arr1 = {1, 2, 3, 4, 5, 6 };
            Console.WriteLine(BinarySearch(arr1, 4));
            Console.WriteLine(BinarySearch(arr1, 7));

            int[] arr2 ={1, 2, 3, 4, 5, 6, 7};
            Console.WriteLine(BinarySearch(arr2, 1));
            Console.WriteLine(BinarySearch(arr2, 10));

            int[] arr3 ={};
            Console.WriteLine(BinarySearch(arr3, 5));
        }
    }
}