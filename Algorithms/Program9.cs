using System;
using System.Collections.Generic;

namespace Algorithms
{
    class Program9
    {
        static void Main(string[] args)
        {
            LinkedList<string> cities = new LinkedList<string>();
            //  AddLast
            cities.AddLast("Mumbai");
            cities.AddLast("Pune");
            cities.AddLast("Ratlam");
            cities.AddLast("Nagpur");
            // AddFirst
            cities.AddFirst("Indore");
            cities.AddFirst("Noida");
            // Contains
            System.Console.WriteLine(cities.Contains("Pune"));
            // Count
            System.Console.WriteLine(cities.Count);
            // Remove
            cities.RemoveFirst();
            // Print
            foreach (string city in cities)
            {
                System.Console.Write(city + " -> ");
            }
            System.Console.WriteLine();
        }
    }
}