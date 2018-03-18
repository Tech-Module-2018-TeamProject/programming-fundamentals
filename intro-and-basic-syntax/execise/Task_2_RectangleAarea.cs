//Confirmed from alex2208 
using System;

namespace SUApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			-------------------------------------------------------------------------------------------------------
			In this task, we need to estimate the area of a rectangle. We are using TryParse method to parse an 
			integer from the console. This way we can make our custom error handling.
			--------------------------------------------------------------------------------------------------------
			*/
			//take the height of the rectangle
			int.TryParse(Console.ReadLine(), out int Height);
			//take the width of the rectangle
			int.TryParse(Console.ReadLine(), out int Width);
			//print the result
			Console.WriteLine( Height * Width);
		}
	}
}
