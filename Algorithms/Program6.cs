using System;
using System.Linq;

namespace Algorithms
{
    class Program5
    {
        static Boolean BinarySearch(int[] arr, int num)
        {
            int min = 0;
            int max = arr.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if(num == arr[mid])
                {
                    return true;
                }
                else if(num > arr[mid])
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,5,6,8,9,11,15,18};
            System.Console.WriteLine(BinarySearch(arr, 21));
            System.Console.WriteLine(BinarySearch(arr, 8));

            // built in method
            System.Console.WriteLine(Array.BinarySearch(arr, 3));
            
        }
    }
}