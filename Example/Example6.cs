using System;
using System.Collections.Generic;

namespace Example
{
    class Example6
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();

            // foreach loop
            var fiveOdds = new List<int> {1, 3, 5, 7, 9};
            var sum = 0;
            foreach (var num in fiveOdds)
            {
                sum += num;
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}