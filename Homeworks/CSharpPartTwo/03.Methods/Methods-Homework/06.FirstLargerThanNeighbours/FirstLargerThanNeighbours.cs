//Problem 6. First larger than neighbours

//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;
using System.Linq;

class FirstLargerThanNeighbours
{
	static void Main()
	{
		string task = "Problem 6. First larger than neighbours\n\nWrite a method that returns the index of the first element in array that is\nlarger than its neighbours, or -1, if there’s no such element.\nUse the method from the previous exercise.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter array(1, 2, 3, 4): ");

		int[] array = GetArrayFromConsole();

		int indexOfFirstLarger = IndexOfFirstLargerThanNeighbours(array);

		if (indexOfFirstLarger < 0)
		{
			Console.WriteLine("No element larger than its neighbours");
		}
		else
		{
			Console.WriteLine("First element larger than ist neighbours: {0}, on index: {1}", array[indexOfFirstLarger], indexOfFirstLarger);
		}
		
	}

	private static int IndexOfFirstLargerThanNeighbours(int[] arr)
	{
		for (int i = 1; i < arr.Length - 1; i++)
		{
			if (IsLargerThanNeighbours(arr, i))
			{
				return i;
			}
		}

		return -1;
	}

	private static bool IsLargerThanNeighbours(int[] arr, int index)
	{
		if (index < 0 || index >= arr.Length)
		{
			throw new ArgumentOutOfRangeException("index", "Index was outside of the bounds of the array");
		}

		if (0 < index && index < arr.Length - 1)
		{
			if (arr[index] > arr[index - 1] && arr[index] > arr[index + 1])
			{
				return true;
			}
		}

		return false;
	}

	private static int[] GetArrayFromConsole()
	{
		string input = Console.ReadLine();
		char[] separators = { ' ', ',' };

		return input.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
	}
}
