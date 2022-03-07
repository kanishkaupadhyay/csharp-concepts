using System;
using System.Linq;

namespace Algorithms
{
    class Program3
    {
        static void ParseString(string s)
        {
            System.Console.WriteLine("Option 1");
            foreach (var ch in s)
            {
                System.Console.WriteLine(ch);
            }
            System.Console.WriteLine("Option 2");
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                System.Console.WriteLine(c);
            }
        }

        static Boolean IsAtEvenIndex(string s, char ch){
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }
            for (int i = 0; i < s.Length; i += 2)
            {
                if(s[i] == ch)
                {
                    return true;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("What the duck?".Contains("duck"));
            ParseString("Hello Duck");
            System.Console.WriteLine("If it is at even index: " + IsAtEvenIndex("tomorrow is holiday", 'o'));
        }
    }
}