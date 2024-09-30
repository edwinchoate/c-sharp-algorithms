using System;

namespace Algorithms
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World".ToLower().Contains("ll"));

            Console.WriteLine(IsAtEvenIndex("hello", 'h'));
            Console.WriteLine(IsAtEvenIndex("hello", 'e'));
            Console.WriteLine(IsAtEvenIndex("hello", 'l'));
            Console.WriteLine(IsAtEvenIndex("hello", 'l'));
            Console.WriteLine(IsAtEvenIndex("hello", 'o'));
        }

        static bool IsAtEvenIndex (string s, char c) 
        {
            if (s == null || s == String.Empty)
                return false;

            for (int i = 0; i < s.Length; i += 2) 
            {
                if (s[i] == c) return true; 
            }
            
            return false;
        }
    }
}