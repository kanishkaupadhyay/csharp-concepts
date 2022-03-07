using System;
using System.Collections;

namespace Algorithms
{
    class Program7
    {
        static int[] FindEvenNums(int[] arr1, int[] arr2)
        {
            ArrayList list = new ArrayList();
            foreach(int item in arr1)
            {
                if(item % 2 == 0)
                {
                    list.Add(item);
                }
            }
            foreach(int item in arr2)
            {
                if(item % 2 == 0)
                {
                    list.Add(item);
                }
            }
            return (int[])list.ToArray(typeof(int));
        }
        static void Main(string[] args)
        {
            int[] arr1 = {-2, -5, -8, 4, 12};
            int[] arr2 = {-10, -4, 16, 19, 17, 14};
            int[] evenArr = FindEvenNums(arr1, arr2);
            Array.ForEach(evenArr, Console.WriteLine);
        }
    }
}