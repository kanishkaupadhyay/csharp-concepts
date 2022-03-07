using System;
using System.Linq;

namespace Algorithms
{
    class Program2
    {
        public static string NormalizeString(string s)
        {
            return s.ToLower().Trim().Replace(",","");
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(NormalizeString("Hello, My name is Tom.   "));
        }
    }
}