//Problem 9. Trapezoids

//Write an expression that calculates trapezoid's area by given sides a and b and height h.
//Examples:

//a	    b	    h	    area
//5	    7	    12	    72
//2	    1	    33	    49.5
//8.5	4.3	    2.7	    17.28
//100	200	    300	    45000
//0.222	0.333	0.555	0.1540125

using System;

class Trapezoids
{
	static void Main()
	{
		string task = "Problem 9. Trapezoids\n\nWrite an expression that calculates trapezoid's area by given sides a and b and height h.\nExamples:\na	b	h	area\n5	7	12	72\n2	1	33	49.5\n8.5	4.3	2.7	17.28\n100	200	300	45000\n0.222	0.333	0.555	0.1540125\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter side a:");
		double sideA = double.Parse(Console.ReadLine());

		Console.WriteLine("Enter side b:");
		double sideB = double.Parse(Console.ReadLine());

		Console.WriteLine("Enter height h:");
		double heightH = double.Parse(Console.ReadLine());

		double area = ((sideA + sideB) * heightH) / 2;

		Console.WriteLine("a: {0}   b: {1}   h: {2}   area: {3}", sideA, sideB, heightH, area);
	}
}
