//Problem 4. Multiplication Sign

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.
//Examples:

// a   b	c	    result
// 5   2	2	    +
//-2  -2	1	    +
//-2   4	3	    -
// 0  -2.5	4	    0
//-1  -0.5 -5.1	    -

using System;

class MultiplicationSign
{
	static void Main()
	{
		string task = "Problem 4. Multiplication Sign\n\nWrite a program that shows the sign (+, - or 0) of the product of three real\nnumbers, without calculating it.\nUse a sequence of if operators.\nExamples:\na	b	c	result\n5	2	2	+\n-2	-2	1	+\n-2	4	3	-\n0	-2.5	4	0\n-1	-0.5	-5.1	-\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.Write("Enter first number: ");
		double firstNumber = double.Parse(Console.ReadLine());

		Console.Write("Enter second number: ");
		double secondNumber = double.Parse(Console.ReadLine());

		Console.Write("Enter third number: ");
		double thirdNumber = double.Parse(Console.ReadLine());

		if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
		{
			Console.WriteLine("result: 0");
		}
		else if((firstNumber > 0) == (secondNumber > 0))
		{
			if (thirdNumber > 0)
			{
				Console.WriteLine("result: +");
			}
			else
			{
				Console.WriteLine("result: -");
			}
		}
		else
		{
			if (thirdNumber > 0)
			{
				Console.WriteLine("result: -");
			}
			else
			{
				Console.WriteLine("result: +");
			}
		}
	}
}
