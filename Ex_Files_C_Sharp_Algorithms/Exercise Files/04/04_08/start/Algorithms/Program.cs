using System;
using System.Collections.Generic;

namespace Algorithms {
    class Program {
        
        static Boolean hasMatchingParentheses(string s) 
        {
            Stack<char> stack = new();

            for (int i = 0; i < s.Length; i++) 
            {
                char current = s[i];

                if (current == '(') 
                {
                    stack.Push(current);
                    continue;
                }

                if (current == ')')
                {
                    if (stack.Count == 0)
                        return false;
                    else 
                    {
                        stack.Pop();
                    }
                }

            }

            return stack.Count == 0;
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