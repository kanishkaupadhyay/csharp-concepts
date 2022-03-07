using System;
using System.Collections.Generic;

namespace Algorithms
{
    class Program10
    {

        static List<int> findMissingElements(int[] arr1, int[] arr2)
        {
            List<int> missing = new List<int>();
            HashSet<int> itemsInSecond = new HashSet<int>();

            foreach (var item in arr2)
            {
                itemsInSecond.Add(item);
            }

            foreach (var item in arr1)
            {
                if(!itemsInSecond.Contains(item))
                {
                    missing.Add(item);
                }
            }
            return missing;
        }
        static void Main(string[] args)
        {
            int[] arr1 = {1,2,5,12};
            int[] arr2 = {7,4,2,9};
            List<int> l = findMissingElements(arr1, arr2);
            foreach (var item in l)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}