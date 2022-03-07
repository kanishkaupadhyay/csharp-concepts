using System;
using System.Collections.Generic;
// print first k binary numbers
namespace Algorithms
{
    class PrintBinary
    {
        static void printBinary(int k)
        {
            if(k <= 0)
            {
                return;
            }
            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            for (int i = 0; i < k; i++)
            {
                int current = q.Dequeue();
                System.Console.WriteLine(current);
                q.Enqueue(current * 10);
                q.Enqueue(current * 10 + 1);
            }
            System.Console.WriteLine();
        }
        static void Main(string[] args)
        {
           printBinary(3);
           printBinary(5);
        }
    }
}