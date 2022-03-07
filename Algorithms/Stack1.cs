using System;
using System.Collections.Generic;

namespace Algorithms
{
    class Stack1
    {
        static void Main(string[] args)
        {
            Stack<int> ones = new Stack<int>();
            // push
            ones.Push(1);
            ones.Push(11);
            ones.Push(111);
            ones.Push(1111);
            ones.Push(11111);
            // pop
            System.Console.WriteLine("Popped Element: " + ones.Pop());
            // top
            System.Console.WriteLine("Top Element: " + ones.Peek());
            
        }
    }
}