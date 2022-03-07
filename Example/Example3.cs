using System;

namespace Example
{
    class Example3
    {   
        static void Main(string[] args){
            // built-in data types
            string name = "Kanishka Upadhyay";
            char firstChar = 'K';
            short heightCm = 180;
            // ushort onlyPositive = ushort.MaxValue;
            int cash = 100000;
            // uint max = uint.MaxValue;
            long bankCash = 500000000;
            // ulong onlyPositive = ulong.MaxValue;
            float half = 1.5f;
            double pi = 3.14;
            bool male = true;
            System.Console.WriteLine(string.Format("{0} {1} {2} {3} {4} {5} {6} {7}", name, firstChar, heightCm, cash, bankCash, half, pi, male));
        }
    }
}