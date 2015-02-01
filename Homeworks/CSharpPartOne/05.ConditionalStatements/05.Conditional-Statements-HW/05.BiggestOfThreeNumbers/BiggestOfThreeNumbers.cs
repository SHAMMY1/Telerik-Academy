//Problem 5. The Biggest of 3 Numbers

//Write a program that finds the biggest of three numbers.
//Examples:

//a	     b	    c	   biggest
//5	     2	    2	   5
//-2	-2	    1	   1
//-2	 4	    3	   4
//0	    -2.5	5	   5
//-0.1	-0.5   -1.1	  -0.1

using System;

class BiggestOfThreeNumbers
{
	static void Main()
	{
		string task = "Problem 5. The Biggest of 3 Numbers\n\nWrite a program that finds the biggest of three numbers.\nExamples:\na	b	c	biggest\n5	2	2	5\n-2	-2	1	1\n-2	4	3	4\n0	-2.5	5	5\n-0.1	-0.5	-1.1	-0.1\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.Write("Enter first number: ");
		double biggestNumber = double.Parse(Console.ReadLine());

		Console.Write("Enter second number: ");
		double secondNumber = double.Parse(Console.ReadLine());

		Console.Write("Enter third number: ");
		double thirdNumber = double.Parse(Console.ReadLine());

		if (biggestNumber < secondNumber)
		{
			biggestNumber = secondNumber;
		}

		if (biggestNumber < thirdNumber)
		{
			biggestNumber = thirdNumber;
		}

		Console.WriteLine("BIggest number: {0}", biggestNumber);
	}
}
