using System;
using System.Linq;

namespace Algorithms
{
    class Program
    {

        static String ReverseEachWord(String sentence) {
            if (sentence == null) 
                return null;
            else if (sentence.Trim() == "")
                return sentence;

            string[] words = sentence.Trim().Split(" ");

            string[] reversedWords = words.Select(Reverse).ToArray();

            return String.Join(' ', reversedWords);
        }

        static String Reverse(String input) {
            if (string.IsNullOrEmpty(input)) {
                return input;
            }

            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new String(arr);
        }

        static void Main(string[] args) {
            Console.WriteLine(ReverseEachWord("Taylor is a great worker"));
            Console.WriteLine(ReverseEachWord(null));
            Console.WriteLine(ReverseEachWord("racer racecar madam"));
            Console.WriteLine(ReverseEachWord("what can I do today"));
            Console.WriteLine(ReverseEachWord(" "));
        }
    }
}