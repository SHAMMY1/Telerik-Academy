//Problem 4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.
//Examples:

//width	height	perimeter	area
//3	       4	   14	     12
//2.5	   3	   11	     7.5
//5	       5	   20	     25

using System;

class Rectangles
{
	static void Main()
	{
		string task = "Problem 4. Rectangles\n\nWrite an expression that calculates rectangle’s perimeter and area by given width and height.\nExamples:\n\nwidth	height	perimeter area\n3	  4	   14	   12\n2.5	  3	   11	   7.5\n5	  5	   20	   25\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter width:");
		double width = double.Parse(Console.ReadLine());

		Console.WriteLine("Enter height:");
		double height = double.Parse(Console.ReadLine());

		double area = width * height;
		double perimeter = (width * 2) + (height * 2);

		Console.WriteLine();
		Console.WriteLine("width: {0}, height: {1}, perimeter: {2}, area: {3}", width, height, perimeter, area);
	}
}
