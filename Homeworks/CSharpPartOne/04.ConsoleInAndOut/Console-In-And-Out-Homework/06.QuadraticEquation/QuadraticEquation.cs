//Problem 6. Quadratic Equation

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
//Examples:

//a	b	c	roots
//2	5	-3	x1=-3; x2=0.5
//-1	3	0	x1=3; x2=0
//-0.5	4	-8	x1=x2=4
//5	2	8	no real roots

using System;

class QuadraticEquation
{
	static void Main()
	{
		string task = "Problem 6. Quadratic Equation\n\nWrite a program that reads the coefficients a, b and c of a quadratic\nequation ax2 + bx + c = 0 and solves it (prints its real roots).\nExamples:\na	b	c	roots\n2	5	-3	x1=-3; x2=0.5\n-1	3	0	x1=3; x2=0\n-0.5	4	-8	x1=x2=4\n5	2	8	no real roots\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);
		Console.Write("Enter A:");
		double a = double.Parse(Console.ReadLine());
		Console.Write("Enter B:");
		double b = double.Parse(Console.ReadLine());
		Console.Write("Enter C:");
		double c = double.Parse(Console.ReadLine());

		double D = Math.Pow(b, 2) - 4 * a * c;
		if (D < 0)
		{
			Console.WriteLine("No real roots.");
		}
		else if (D == 0)
		{
			double x = -b / (2 * a);
			Console.WriteLine("x1 = x2 = {0}", x);
		}
		else
		{
			double x1 = (-b + Math.Sqrt(D)) / (2 * a);
			double x2 = (-b - Math.Sqrt(D)) / (2 * a);

			Console.WriteLine("x1 = {0}\nx2 = {1}", x1, x2);
		}
	}
}
