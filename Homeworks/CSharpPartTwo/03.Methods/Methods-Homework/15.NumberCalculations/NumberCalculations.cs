//Problem 15.* Number calculations

//Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
//Use generic method (read in Internet about generic methods in C#).

using System;
using System.Linq;

class NumberCalculations
{
	static void Main()
	{
		string task = "Problem 15.* Number calculations\n\nModify your last program and try to make it work for any number type, not just\ninteger (e.g. decimal, float, byte, etc.)\nUse generic method (read in Internet about generic methods in C#).\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);
		Console.WriteLine("Enter int array(1, 2, 3, 4): ");
		int[] intArray = GetIntArrayFromConsole();
		Console.WriteLine("\nMinimum: {0}\nMaximum: {1}\nAverage: {2:F2}\nSum: {3}\nProduct: {4}", GetMin(intArray), GetMax(intArray), GetAverage(intArray), GetSum(intArray), GetProduct(intArray));

		Console.WriteLine("Enter double array(1.2, 2.3, 3.4, 4): ");
		double[] doubleArray = GetDoubleArrayFromConsole();
		Console.WriteLine("\nMinimum: {0}\nMaximum: {1}\nAverage: {2:F2}\nSum: {3}\nProduct: {4}", GetMin(doubleArray), GetMax(doubleArray), GetAverage(doubleArray), GetSum(doubleArray), GetProduct(doubleArray));

		Console.WriteLine("Enter decimal array(1, 2, 3, 4): ");
		decimal[] decimalArray = GetDecimalArrayFromConsole();
		Console.WriteLine("\nMinimum: {0}\nMaximum: {1}\nAverage: {2:F2}\nSum: {3}\nProduct: {4}", GetMin(decimalArray), GetMax(decimalArray), GetAverage(decimalArray), GetSum(decimalArray), GetProduct(decimalArray));

	}

	private static T GetMin<T>(params T[] set) where T : IComparable<T>
	{
		if (set.Length == 0)
		{
			throw new ArgumentNullException("set", "Set cannot be empty");
		}
		T min = set[0];

		for (int i = 0; i < set.Length; i++)
		{
			if (min.CompareTo(set[i] ) > 0)
			{
				min = set[i];
			}
		}

		return min;
	}

	private static T GetMax<T>(params T[] set) where T : IComparable<T>
	{
		if (set.Length == 0)
		{
			throw new ArgumentNullException("set", "Set cannot be empty");
		}
		T max = set[0];

		for (int i = 0; i < set.Length; i++)
		{
			if (max.CompareTo(set[i]) < 0)
			{
				max = set[i];
			}
		}

		return max;
	}

	private static double GetAverage<T>(params T[] set)
	{
		if (set.Length == 0)
		{
			throw new ArgumentNullException("set", "Set cannot be empty");
		}

		return (double)(dynamic)GetSum(set) / set.Length;
	}

	private static T GetSum<T>(params T[] set)
	{
		if (set.Length == 0)
		{
			throw new ArgumentNullException("set", "Set cannot be empty");
		}
		dynamic sum = 0;

		foreach (var number in set)
		{
			sum += number;
		}

		return (T)sum;
	}

	private static T GetProduct<T>(params T[] set)
	{
		dynamic product = set[0];

		for (int i = 1; i < set.Length; i++)
		{
			product *= set[i];
		}

		return (T)product;
	}

	private static int[] GetIntArrayFromConsole()
	{
		string input = Console.ReadLine();
		char[] separators = { ' ', ',' };

		return input.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
	}

	private static double[] GetDoubleArrayFromConsole()
	{
		string input = Console.ReadLine();
		char[] separators = { ' ', ',' };

		return input.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(x => double.Parse(x)).ToArray();
	}

	private static decimal[] GetDecimalArrayFromConsole()
	{
		string input = Console.ReadLine();
		char[] separators = { ' ', ',' };

		return input.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(x => decimal.Parse(x)).ToArray();
	}
}
