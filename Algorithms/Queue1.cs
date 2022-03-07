using System;
using System.Collections.Generic;

namespace Algorithms
{
    class Queue1
    {
        static void Main(string[] args)
        {
            Queue<int> primes = new Queue<int>();
            //  enqueue
            primes.Enqueue(2);
            primes.Enqueue(3);
            primes.Enqueue(5);
            primes.Enqueue(7);
            primes.Enqueue(11);
            primes.Enqueue(13);
            //  dequeue
            primes.Dequeue();
            primes.Dequeue();
            // peek
            System.Console.WriteLine(primes.Peek());
            int[] arr = primes.ToArray();
            System.Console.WriteLine("Printing the converted array");
            foreach (var prime in arr)
            {
                System.Console.WriteLine(prime);
            }
        }
    }
}