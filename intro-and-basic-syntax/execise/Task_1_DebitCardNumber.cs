//confirmed by gogata258
using System;

namespace _01_Debit_card
{
    class Program
    {
        static void Main(string[] args)
        {
            // we recieve from the console each one of the four card number parts
            int redica1 = int.Parse(Console.ReadLine());
            int redica2 = int.Parse(Console.ReadLine());
            int redica3 = int.Parse(Console.ReadLine());
            int redica4 = int.Parse(Console.ReadLine());
            
            
            // we print the complete card number in a 4er placeholders for each part number. 
            Console.Write("{0:d4} ", int1);
            Console.Write("{0:d4} ", int2);
            Console.Write("{0:d4} ", int3);
            Console.Write("{0:d4} ", int4);
        }
    }
}
