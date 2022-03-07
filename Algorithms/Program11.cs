using System;
using System.Collections.Generic;

namespace Algorithms
{
    class Program11
    {
        static void DisplayFreqOfEachElement(int[] arr)
        {
            Dictionary<int, int> freqDict = new Dictionary<int, int>();

            for(int i = 0; i < arr.Length; i++)
            {
                if(freqDict.ContainsKey(arr[i]))
                {
                    freqDict[arr[i]]++;
                }
                else
                {
                    freqDict[arr[i]] = 1;
                }
            }

            foreach (KeyValuePair<int, int> k in freqDict)
            {
                System.Console.WriteLine(k.Key + " -> " + k.Value);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = {1,2,5,10,1,3,4,5,6,4,3,5,7,8,8,6,4};
            DisplayFreqOfEachElement(arr);
            
        }
    }
}