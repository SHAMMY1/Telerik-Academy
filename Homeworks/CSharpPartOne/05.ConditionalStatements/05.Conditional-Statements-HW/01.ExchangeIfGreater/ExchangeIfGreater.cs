//Problem 1. Exchange If Greater

//Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater 
//than the second one. As a result print the values a and b, separated by a space.
//Examples:

//a	    b	   result
//5	    2	   2 5
//3	    4	   3 4
//5.5	4.5	   4.5 5.5

using System;

class ExchangeIfGreater
{
	static void Main()
	{
		string task = "Problem 1. Exchange If Greater\n\nWrite an if-statement that takes two double variables a and b and exchanges\ntheir values if the first one is greater than the second one. As a result\nprint the values a and b, separated by a space.\nExamples:\na	b	result\n5	2	2 5\n3	4	3 4\n5.5	4.5	4.5 5.5\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.Write("Enter variable a: ");
		double variableA = double.Parse(Console.ReadLine());

		Console.Write("Enter variable b: ");
		double variableB = double.Parse(Console.ReadLine());

		if (variableA > variableB)
		{
			double temp = variableA;
			variableA = variableB;
			variableB = temp;
		}

		Console.WriteLine("result:\n{0} {1}", variableA, variableB);
	}
}
