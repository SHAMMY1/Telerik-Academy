//Problem 5. Larger than neighbours

//Write a method that checks if the element at given position in given array of integers is larger
//than its two neighbours (when such exist).

using System;
using System.Linq;

class LargerThanNeighbours
{
	static void Main(string[] args)
	{
		string task = "Problem 5. Larger than neighbours\nWrite a method that checks if the element at given position in given array of\nintegers is larger than its two neighbours (when such exist).\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter array(1, 2, 3, 4): ");

		int[] array = GetArrayFromConsole();

		Console.Write("Enetr index: ");

		int index = int.Parse(Console.ReadLine());

		bool largerThanNeighbours = IsLargerThanNeighbours(array, index);

		Console.WriteLine("Is integer in index {0} larger than its two neighbours: {1}",index, largerThanNeighbours);
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
