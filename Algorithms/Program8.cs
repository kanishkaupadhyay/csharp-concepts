using System;

namespace Algorithms
{
    class Program8
    {
        public static int[] Reverse(int[] arr)
        {
            int[] reversed = new int[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                reversed[i] = arr[arr.Length - i - 1];
            }
            return reversed;
        }

        public static void ReverseInPlace(int[] arr)
        {
            // we only need to iterate half as many items in the list
            for(int i = 0; i < arr.Length / 2; i++)
            {
                // swap
                int temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;
            }
        }
        static void Main(string[] args)
        {
            int[] arr1 = {1, 2, 3, 4, 5};
            int[] reversed = Reverse(arr1);
            Array.ForEach(reversed, Console.WriteLine);
            int[] arr2 = {2, 3, 4, 5, 6, 7};
            System.Console.WriteLine("Reversed in Place");
            ReverseInPlace(arr2);
            Array.ForEach(arr2, Console.WriteLine);
        }
    }
}