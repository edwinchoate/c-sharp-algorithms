using System;
using System.Text;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse("Hello World"));
            Console.WriteLine(Reverse(""));
            Console.WriteLine(Reverse(null));
        }

        static string Reverse (string s) 
        {
            if (String.IsNullOrEmpty(s)) return s;

            char[] c = s.ToCharArray();
            Array.Reverse(c);
            return new string(c);
        }

        // static string Reverse (string s) 
        // {
        //     if (String.IsNullOrEmpty(s)) return s;

        //     StringBuilder sb = new();

        //     for (int i = s.Length - 1; i >= 0; i--) 
        //     {
        //         sb.Append(s[i]);
        //     }

        //     return sb.ToString();
        // }
    }
}