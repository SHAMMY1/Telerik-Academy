//Problem 14. Integer calculations

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

using System;
using System.Linq;

class IntegerCalculations
{
	static void Main()
	{
		string task = "Problem 14. Integer calculations\n\nWrite methods to calculate minimum, maximum, average, sum and product of given\nset of integer numbers.\nUse variable number of arguments.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter array(1, 2, 3, 4): ");
		int[] set = GetArrayFromConsole();

		Console.WriteLine("\nMinimum: {0}\nMaximum: {1}\nAverage: {2:F2}\nSum: {3}\nProduct: {4}", GetMin(set), GetMax(set), GetAverage(set), GetSum(set), GetProduct(set));
	}

	private static int GetMin(params int[] set)
	{
		if (set.Length == 0)
		{
			throw new ArgumentNullException("set","Set cannot be empty");
		}
		int min = int.MaxValue;

		for (int i = 0; i < set.Length; i++)
		{
			if (min > set[i])
			{
				min = set[i];
			}
		}

		return min;
	}

	private static int GetMax(params int[] set)
	{
		if (set.Length == 0)
		{
			throw new ArgumentNullException("set", "Set cannot be empty");
		}
		int max = int.MinValue;

		for (int i = 0; i < set.Length; i++)
		{
			if (max < set[i])
			{
				max = set[i];
			}
		}

		return max;
	}

	private static double GetAverage(params int[] set)
	{
		if (set.Length == 0)
		{
			throw new ArgumentNullException("set", "Set cannot be empty");
		}

		return (double)GetSum(set) / set.Length;
	}

	private static int GetSum(params int[] set)
	{
		if (set.Length == 0)
		{
			throw new ArgumentNullException("set", "Set cannot be empty");
		}
		int sum = 0;

		foreach (var number in set)
		{
			sum += number;
		}

		return sum;
	}

	private static int GetProduct(params int[] set)
	{
		int product = set[0];

		for (int i = 1; i < set.Length; i++)
		{
			product *= set[i];
		}

		return product;
	}

	private static int[] GetArrayFromConsole()
	{
		string input = Console.ReadLine();
		char[] separators = { ' ', ',' };

		return input.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
	}
}
