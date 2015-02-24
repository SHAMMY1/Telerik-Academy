//Problem 10. N Factorial

//Write a program to calculate n! for each n in the range [1..100].

//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

class NFactorial
{
	static void Main()
	{
		string task = "Problem 10. N Factorial\n\nWrite a program to calculate n! for each n in the range [1..100].\n\nHint: Implement first a method that multiplies a number represented as array of digits by given integer number.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter number n: ");

		int n = int.Parse(Console.ReadLine());
		Stopwatch watch = new Stopwatch();
		watch.Start();
		int[] result = { 1 };

		for (int i = 1; i <= n; i++)
		{
			result = MultiplyNumbers(i, result);
			//if (i % 1000 == 0)
			//{
			//	//Console.WriteLine(i);
			//}
		}
		//Console.WriteLine();
		Console.WriteLine("Result: ");
		Console.SetBufferSize(100, 1000);
		PrintNumber(result);
		watch.Stop();

		Console.WriteLine(watch.Elapsed);
	}

	private static int[] MultiplyNumbers(int number, int[] second)
	{
		int[] first = number.ToString().Select(c => int.Parse(c.ToString())).ToArray();

		int reminder = 0;
		int[] result = { 0 };
 
		for (int i = first.Length - 1; i >= 0; i--)
		{
			reminder = 0;
			List<int> current = new List<int>();
			for (int l = 0; l < first.Length - 1 - i; l++)
			{
			 current.Add(0);
			}
			for (int j = second.Length - 1; j >= 0; j--)
			{
				current.Add(((first[i] * second[j]) % 10) + reminder);
				reminder = (first[i] * second[j]) / 10;
			}
			if (reminder != 0)
			{
				current.Add(reminder);
			}
			current.Reverse();
			result = AddsNumbers(result, current.ToArray());
		}



		return result;
		
	}

	private static int[] AddsNumbers(int[] first, int[] second)
	{
		int[][] arrays = new int[2][];

		arrays[0] = first.Length < second.Length ? first : second;
		arrays[1] = arrays[0] == first ? second : first;

		List<int> result = new List<int>();

		int j, i;

		int reminder = 0;

		for (i = arrays[0].Length - 1, j = arrays[1].Length - 1; i >= 0; i--, j--)
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


}
