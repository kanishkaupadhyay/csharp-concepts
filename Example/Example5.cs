using System;

enum weekDays
{
    Monday=1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}

namespace Example
{
    class Example5
    {
        static void Main(string[] args){
            int x = -5;
            Console.WriteLine(Math.Abs(x));
            Console.WriteLine(Math.Pow(x,2));
            Console.WriteLine(Math.Round(5.2));
            Console.WriteLine(Math.PI);

            // const and enum
            const float g = 9.8f;
            Console.WriteLine("Accelaration due to gravity on " + weekDays.Monday + " is " + g + " meter/second sq");
        }
    }
}