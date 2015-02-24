//Problem 8. Number as array

//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit;
//the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;
using System.Linq;

class NumberAsArray
{
	static void Main()
	{
		string task = "Problem 8. Number as array\n\nWrite a method that adds two positive integer numbers represented as arrays\nof digits (each array element arr[i] contains a digit; the last digit is\nkept in arr[0]).\nEach of the numbers that will be added could have up to 10 000 digits.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.Write("Enter the first number: ");
		int[] first = GetNumberFromConsole();
		Console.Write("Enter the second number: ");
		int[] second = GetNumberFromConsole();

		int[] result = AddsNumbers(first, second);

		Console.Write("Result: ");
		PrintNumber(result);
	}

	private static int[] AddsNumbers(int[] first, int[] second)
	{
		int[][] arrays = new int[2][];

		arrays[0] = first.Length < second.Length ? first : second; 
		arrays[1] = arrays[0] == first ? second : first;

		List<int> result = new List<int>();

		int j,i;

		int reminder = 0;

		for (i = arrays[0].Length - 1, j = arrays[1].Length - 1; i >= 0; i--,j--)
		{
			result.Add(((arrays[0][i] + arrays[1][j]) + reminder) % 10);

			reminder = ((arrays[0][i] + arrays[1][j]) + reminder) / 10;
		}
		while (j >= 0)
		{
			result.Add((arrays[1][j] + reminder) % 10);
			reminder = (arrays[1][j] + reminder) / 10;
			j--;

		}
		if (reminder != 0)
		{
			result.Add(reminder);
		}
		result.Reverse();
		return result.ToArray();
	}

	private static void PrintNumber(int[] arr)
	{
		for (int i = 0; i < arr.Length; i++)
		{
			Console.Write(arr[i]);
		}
		Console.WriteLine();
	}

	private static int[] GetNumberFromConsole()
	{
		string input = Console.ReadLine();

		if (input.Any(c => !Char.IsDigit(c)))
		{
			throw new ArgumentException("The number must be positive and contain only digits");
		}

		return input.ToCharArray().Select(c => int.Parse(c.ToString())).ToArray();
	}
}
