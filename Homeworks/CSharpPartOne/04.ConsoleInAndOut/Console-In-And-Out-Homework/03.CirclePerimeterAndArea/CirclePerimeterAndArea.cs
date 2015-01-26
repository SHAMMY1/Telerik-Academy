//Problem 3. Circle Perimeter and Area

//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
//Examples:

//r	    perimeter	area
//2	    12.57	    12.57
//3.5	21.99	    38.48

using System;

class CirclePerimeterAndArea
{
	static void Main()
	{
		string task = "Problem 3. Circle Perimeter and Area\n\nWrite a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.\nExamples:\nr	perimeter	area\n2	12.57	       12.57\n3.5	21.99	       38.48\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);
	}
}
