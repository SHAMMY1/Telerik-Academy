//Problem 8. Maximal sum

//Write a program that finds the sequence of maximal sum in given array.
//Example:

//input	                                result
//2, 3, -6, -1, 2, -1, 6, 4, -8, 8	    2, -1, 6, 4

//Can you do it with only one loop (with single scan through the elements of the array)?

using System;
using System.Linq;

class MaximalSum
{
	static void Main()
	{
		string task = "Problem 8. Maximal sum\n\nWrite a program that finds the sequence of maximal sum in given array.\nExample:\ninput	                                result\n2, 3, -6, -1, 2, -1, 6, 4, -8, 8	2, -1, 6, 4\n\nCan you do it with only one loop\n(with single scan through the elements of the array)?\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter array(1, 2, 3, 4): ");
		int[] numbers = GetsArrayFromConsole();

		int startIndex = 0;
		int endIndex = 0;
		int maxSum = numbers[0];
		int currentSum = numbers[0];

		for (int i = 1; i < numbers.Length; i++)
		{
			currentSum += numbers[i];

			if (currentSum < numbers[i])
			{
				currentSum = numbers[i];
				startIndex = i;
			}

			if (currentSum >= maxSum)
			{
				maxSum = currentSum;
				endIndex = i;
			}
		}

		Console.Write("\nSequence: ");
		for (int i = startIndex; i <= endIndex; i++)
		{
			Console.Write("{0} ", numbers[i]);
		}

		Console.WriteLine("\nSum: {0}", maxSum);

	}

	private static int[] GetsArrayFromConsole()
	{
		string input = Console.ReadLine();
		char[] separators = { ' ', ',' };

		return input.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
	}
}
