//Problem 16.* Print Long Sequence

//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
//You might need to learn how to use loops in C# (search in Internet).
using System;

class PrintLongSequence
{
	static void Main()
	{
		int numbersCount = 1000;
		int startNumber = 2;
		int endNumber = startNumber + numbersCount - 1;

		for (int i = startNumber; i <= endNumber; i++)
		{
			if (i % 16 == 0)
			{
				Console.WriteLine("\n");
			}
			string messageToPrint = (string.Format("{0} ", (i % 2 == 0) ? i : -i)).PadRight (5);
			Console.Write(messageToPrint);
		}
		Console.WriteLine();
	}
}
