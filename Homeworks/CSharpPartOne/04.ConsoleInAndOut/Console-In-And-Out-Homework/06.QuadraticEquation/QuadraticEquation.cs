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
	}
}
