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

		Console.WriteLine("Enter radius:");
		double radius = double.Parse(Console.ReadLine());

		double perimeter = Math.PI * radius * 2;
		double area = Math.PI * Math.Pow(radius, 2);

		Console.WriteLine("Perimeter: {0:F2}   Area: {1:F2}", perimeter, area);
	}
}
