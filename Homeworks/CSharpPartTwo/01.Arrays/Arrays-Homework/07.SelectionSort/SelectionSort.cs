//Problem 7. Selection sort

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position,
//find the smallest from the rest, move it at the second position, etc.

using System;
using System.Linq;

class SelectionSort
{
	static void Main()
	{
		string task = "Problem 7. Selection sortn\\nSorting an array means to arrange its elements\nin increasing order. Write a program to sort an array.\nUse the Selection sort algorithm: Find the smallest element,\nmove it at the first position, find the smallest from the rest,\nmove it at the second position, etc.\n";


		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter array(1, 2, 3, 4): ");
		int[] array = GetsArrayFromConsole();

		

		for (int i = 0; i < array.Length; i++)
		{
			int minNumber = array[i];

			for (int j = i + 1; j < array.Length; j++)
			{
				if (minNumber > array[j])
				{
					minNumber = array[j];
				}
			}

			array[Array.IndexOf(array, minNumber, i)] = array[i];
			array[i] = minNumber;

		}


			Console.WriteLine("Sorted array:\n{0}",string.Join(", ", array));

	}

	private static int[] GetsArrayFromConsole()
	{
		string input = Console.ReadLine();
		char[] separators = { ' ', ',' };

		return input.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
	}
}
