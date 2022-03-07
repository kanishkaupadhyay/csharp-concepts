using System;
using System.Linq;

namespace Algorithms
{
    class Program1
    {
        static bool IsUpperCase(string s){
            return s.All(char.IsUpper);
        }
        static bool IsLowerCase(string s){
            return s.All(char.IsLower);
        }

        static Boolean IsPasswordStrong(string s)
        {
            return s.Any(char.IsUpper) && s.Any(char.IsLower) && s.Any(char.IsDigit);
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(IsUpperCase(s)); 
            Console.WriteLine(IsLowerCase(s));
            string password = Console.ReadLine();
            if(IsPasswordStrong(password))
            {
                Console.WriteLine("Strong Password");
            }
            else
            {
                Console.WriteLine("Weak Password");
            }
        }
    }
}