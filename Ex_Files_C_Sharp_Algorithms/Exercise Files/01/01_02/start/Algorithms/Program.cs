using System;

namespace Algorithms
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(NormalizeString("  Hello, World  "));
        }

        static string NormalizeString (string s) 
        {
            return s.ToLower()
                    .Replace(",", "")
                    .Trim();
        }
    }
}