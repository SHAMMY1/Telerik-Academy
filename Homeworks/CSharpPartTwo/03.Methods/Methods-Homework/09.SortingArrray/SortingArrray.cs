//Problem 9. Sorting array

//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Linq;

class SortingArrray
{
	static void Main()
	{
		string task = "Problem 9. Sorting array\n\nWrite a method that return the maximal element in a portion of array\nof integers starting at given index.\nUsing it write another method that sorts an array in ascending/descending order.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter array(1, 2, 3, 4): ");

		int[] numbers = GetArrayFromConsole();

		SortArrayAscending(numbers);

		Console.WriteLine("Sorted ascending array: {0}", string.Join(", ", numbers));

		SortArrayDescending(numbers);

		Console.WriteLine("Sorted descending array: {0}", string.Join(", ", numbers));


	}

	private static void SortArrayDescending(int[] arr)
	{
		int maxNumber;

		for (int i = 0; i < arr.Length; i++)
		{
			maxNumber = GetMaxElement(arr, i, arr.Length - 1);

			arr[Array.IndexOf(arr, maxNumber, i)] = arr[i];
			arr[i] = maxNumber;
		}
	}

	private static void SortArrayAscending(int[] arr)
	{
		int maxNumber;

		for (int i = 0; i < arr.Length; i++)
		{
			maxNumber = GetMaxElement(arr, 0, arr.Length - 1 - i);

			arr[Array.IndexOf(arr, maxNumber, 0, arr.Length - i)] = arr[arr.Length - i - 1];
			arr[arr.Length - i - 1] = maxNumber;
		}
	}

	private static int GetMaxElement(int[] arr, int startIndex, int endIndex)
	{
		if (arr.Length <= startIndex || startIndex < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex", "Start index must be >= 0 and < array.lenght");
		}

		if (arr.Length <= endIndex || endIndex < 0)
		{
			throw new ArgumentOutOfRangeException("endIndex", "end index must be >= 0 and < array.lenght");
		}

		int maxElement = int.MinValue;

		for (int i = startIndex; i <= endIndex; i++)
		{
			if (maxElement < arr[i])
			{
				maxElement = arr[i];
			}
		}

		return maxElement;
	}

	private static int[] GetArrayFromConsole()
	{
		string input = Console.ReadLine();
		char[] separators = { ' ', ',' };

		return input.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
	}

	
}
