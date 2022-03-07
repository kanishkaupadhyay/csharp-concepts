using System;
using System.Linq;
using System.Text;
namespace Algorithms
{
    class Program4
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
        static void Main(string[] args)
        {
            System.Console.WriteLine(Reverse("Lollopop"));
            System.Console.WriteLine(ReverseUsingArray("Popcorns"));
        }
    }
}