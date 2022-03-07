using System;
using System.Collections.Generic;

// for the challenge reverse every word in a string sentence on its own place
namespace Algorithms
{
    class   HeraPheri
    {
        string name;
        int id;
        string dapartment;

        public HeraPheri(string name, int id, string department)
        {
            this.name = name;
            this.id = id;
            this.dapartment = department;
        }
        static void Main(string[] args)
        {
            HeraPheri ram = new HeraPheri("Ram", 1001, "Finance");
            HeraPheri shyam = new HeraPheri("Shyam", 1002, "Manager");
            HeraPheri baburao = new HeraPheri("Baburao", 1003, "HR");

            Dictionary<int, HeraPheri> herapheri = new Dictionary<int,  HeraPheri>();
            herapheri.Add(ram.id, ram);
            herapheri.Add(shyam.id, shyam);
            herapheri.Add(baburao.id, baburao);

            HeraPheri h;
            if(herapheri.TryGetValue(1001,  out h))
            {
                System.Console.WriteLine(h.name + " : " + h.dapartment);
            }
        }
    }
}