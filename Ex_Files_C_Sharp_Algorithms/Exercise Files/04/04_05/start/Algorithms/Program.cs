using System;
using System.Collections.Generic;

namespace Algorithms {
    class Program {

        static void Main(string[] args) 
        {

            Stack<string> stack = new();

            Console.WriteLine("START Main");
            stack.Push("Main");

            Console.WriteLine("START ResponseBuilder");
            stack.Push("ResponseBuilder");

            Console.WriteLine("START CallExternalService");
            stack.Push("CallExternalService");
            
            Console.WriteLine("END " + stack.Pop());

            Console.WriteLine("START ParseInternalData");
            stack.Push("ParseInternalData");

            Console.WriteLine("END " + stack.Pop());
            Console.WriteLine("END " + stack.Pop());
            Console.WriteLine("END " + stack.Pop());

        }
    }
}