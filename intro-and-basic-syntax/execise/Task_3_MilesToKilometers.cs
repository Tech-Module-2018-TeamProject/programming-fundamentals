using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 mile == 1.60934 kilometers
            //read miles from console
            double miles = int.Parse(Console.ReadLine());
            //convert miles to kilometers
            double kilometers = (miles * 1.60934);
            //print kilometers to console
            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
