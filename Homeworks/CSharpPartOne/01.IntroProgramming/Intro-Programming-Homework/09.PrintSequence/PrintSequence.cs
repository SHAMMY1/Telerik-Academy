//Problem 9. Print a Sequence

//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
using System;

class PrintSequence
{
	static void Main()
	{
		int numbersCount = 10;
		int startNumber = 2;

		for (int i = startNumber; i < numbersCount + startNumber; i++)
		{
			string messageToPrint = string.Format("{0} ", (i % 2 == 0) ? i : -i);
			Console.Write(messageToPrint);
		}
		Console.WriteLine();
	}
}
