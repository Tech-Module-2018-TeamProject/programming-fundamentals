//CONFIRMED BY Daneto123
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 mile == 1.60934 kilometers
            //read milesChanged from console
            double milesChanged = int.Parse(Console.ReadLine());
            //convert milesChanged to kilometers
            double kilometers = (milesChanged * 1.60934);
            //print kilometers to console
            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
