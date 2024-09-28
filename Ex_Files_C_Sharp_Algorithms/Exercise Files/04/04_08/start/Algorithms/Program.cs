using System;
using System.Collections.Generic;

namespace Algorithms {
    class Program {
        
         static Boolean hasMatchingParentheses(string s) {
             return false;
        }

        static void Main(string[] args) {
            Console.WriteLine(hasMatchingParentheses("((hello()))"));
            Console.WriteLine(hasMatchingParentheses("()(hello())"));
            Console.WriteLine(hasMatchingParentheses("((hello))"));
            Console.WriteLine(hasMatchingParentheses("(hello)"));

            Console.WriteLine();

            Console.WriteLine(hasMatchingParentheses("(hello("));
            Console.WriteLine(hasMatchingParentheses(")hello)"));
            Console.WriteLine(hasMatchingParentheses(")hello("));
            Console.WriteLine(hasMatchingParentheses("hello(("));
            Console.WriteLine(hasMatchingParentheses("(hello"));
            Console.WriteLine(hasMatchingParentheses("((hello)"));
        }
    }
}