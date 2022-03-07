using System;
using System.Linq;
using System.Text;

// for the challenge reverse every word in a string sentence on its own place
namespace Algorithms
{
    class Challenge1
    {
        public static string Reverse(string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return input;
            }

            StringBuilder reversed = new StringBuilder(input.Length);
            for (int i = input.Length-1; i >= 0; i--)
            {
                reversed.Append(input[i]);
            }
            return reversed.ToString();
        }

        public static string ReverseUsingArray(string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return input;
            }
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        static string WordsReversed(string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return input;
            }
            string[] arr = input.Split(' ');
            StringBuilder reversedWords = new StringBuilder(arr.Length);
            foreach (var word in arr)
            {
                var newWord = Reverse(word);
                reversedWords.Append(newWord + " ");
            }
            return reversedWords.ToString().Trim();
        }
        static void Main(string[] args)
        {
            string sentence = "There is a flowerpot on the table";
            Console.WriteLine(WordsReversed(sentence));
        }
    }
}