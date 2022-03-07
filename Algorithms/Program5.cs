using System;
using System.Linq;

namespace Algorithms
{
    class Program5
    {
        static int LinearSearch(int[] arr, int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(num == arr[i])
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr = {1,2,5,12,8,17,34,21,64,72,20};
            System.Console.WriteLine(LinearSearch(arr, 21));
            System.Console.WriteLine(LinearSearch(arr, 14));
            System.Console.WriteLine("Built in Methods");
            // built in Array methods
            int n = Array.Find(arr, element => element == 5);
            System.Console.WriteLine(n);
            int[] items = Array.FindAll(arr, element => element > 5);
            Array.ForEach(items, Console.WriteLine);
        }
    }
}