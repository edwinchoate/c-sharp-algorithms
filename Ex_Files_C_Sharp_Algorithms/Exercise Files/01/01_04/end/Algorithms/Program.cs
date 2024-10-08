﻿using System;
using System.Text;

namespace Algorithms
{
    class Program
    {

        static String Reverse(String input) {
            if(string.IsNullOrEmpty(input)) {
                return input;
            }

            StringBuilder reversed = new StringBuilder(input.Length);
            
            for (int i = input.Length - 1; i >= 0; i--){
                reversed.Append(input[i]);
            }

            return reversed.ToString();
        }

        static String Reverse2(String input) {
            if(string.IsNullOrEmpty(input)) {
                return input;
            }

            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new String(arr);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Reverse2("Hello World"));
            Console.WriteLine(Reverse2(""));
            Console.WriteLine(Reverse2("hello"));
            Console.WriteLine(Reverse2("tacos"));
            Console.WriteLine(Reverse2("Hi!"));
            Console.WriteLine(Reverse2(null));
        }
    }
}