//Problem 5. Maximal increasing sequence

//Write a program that finds the maximal increasing sequence in an array.
//Example:

//input	                    result
//3, 2, 3, 4, 2, 2, 4	    2, 3, 4

using System;
using System.Linq;

class MaximalIncreasingSequence
{
	static void Main()
	{
		string task = "Problem 5. Maximal increasing sequence\n\nWrite a program that finds the maximal increasing sequence in an array.\nExample:\ninput	                result\n3, 2, 3, 4, 2, 2, 4	2, 3, 4\n";


		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter array(1, 2, 3, 4): ");
		int[] numbers = GetsArrayFromConsole();

		int maxSequence = 0;
		int startIndex = 0;
		int endIndex = 0;

		for (int i = 0; i < numbers.Length - 1; i++)
		{
			int currentSequence = 1;

			while (i < numbers.Length -1 && numbers[i] < numbers[i + 1])
			{
				currentSequence++;
				i++;
			}

			if (currentSequence > maxSequence)
			{
				maxSequence = currentSequence;
				endIndex = i;
				startIndex = currentSequence > 1 ? endIndex - (maxSequence - 1) : endIndex;
			}
		}

		Console.Write("Maximal sequence: ");

		for (int i = startIndex; i <= endIndex; i++)
		{
			Console.Write("{0} ", numbers[i]);
		}

		Console.WriteLine();
	}

	private static int[] GetsArrayFromConsole()
	{
		string input = Console.ReadLine();
		char[] separators = { ' ', ',' };

		return input.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
	}
}
