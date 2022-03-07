using System;
using System.Collections.Generic;

namespace Algorithms
{
    class NextGreaterElement
    {
        static void PrintNextGreaterElement(int[] arr)
        {
            if(arr.Length <= 0 )
            {
                return;
            }

            Stack<int> stack = new Stack<int>();
            stack.Push(arr[0]);
            for(int i = 1; i < arr.Length; i++)
            {
                int next = arr[i];
                if(stack.Count > 0)
                {
                    int popped = stack.Pop();

                    while (popped < next)
                    {
                        System.Console.WriteLine(popped + "-->" + next);
                        popped = stack.Pop();
                        if(stack.Count == 0)
                        {
                            break;
                        }
                        stack.Pop();
                    }

                    if(popped > next)
                    {
                        stack.Push(popped);
                    }
                }
                stack.Push(next);
            }
            while(stack.Count > 0)
            {
                System.Console.WriteLine(stack.Pop() + "-->" + -1);
            }    
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] {15, 4, 8, 10};
            PrintNextGreaterElement(arr);
        }
    }
}