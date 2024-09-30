using System;
using System.Linq;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsUppercase("Hello World"));
            Console.WriteLine(IsUppercase("HELLO WORLD"));
            Console.WriteLine(IsUppercase("HELLOWORLD"));

            Console.WriteLine();
            
            Console.WriteLine(IsLowercase("hello world"));
            Console.WriteLine(IsLowercase("helloworld"));

            Console.WriteLine();

            Console.WriteLine(IsPasswordComplex("hello world"));
            Console.WriteLine(IsPasswordComplex("hEllo world"));
            Console.WriteLine(IsPasswordComplex("hell0 world"));
            Console.WriteLine(IsPasswordComplex("hEll0 world"));
        }

        static Boolean IsPasswordComplex (string password) 
        {
            return password.Any(char.IsNumber) && password.Any(char.IsUpper) && password.Any(char.IsLower);
        }

        static Boolean IsUppercase (string s) 
        {
            return s.All(char.IsUpper); // .All is from System.Linq
        }

        static Boolean IsLowercase (string s) 
        {
            return s.All(char.IsLower); // .All is from System.Linq
        }

    }
}