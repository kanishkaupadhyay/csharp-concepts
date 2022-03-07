using System;

namespace Example
{
    class Example2
    {
        public static string name = "Kanishka Upadhyay";
        public static int x;
        static void Main(string[] args){
            x = 10;
            string message = string.Format("Welcome {0}", name);
            Console.WriteLine(message);
        }
    }
}