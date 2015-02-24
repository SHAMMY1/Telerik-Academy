//Problem 4. Binary search

//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using
//the method Array.BinSearch() finds the largest number in the array which is ≤ K.

using System;
using System.Linq;

class BinarySearch
{
	static void Main()
	{
		string task = "Problem 4. Binary search\n\nWrite a program, that reads from the console an array of N integers and\nan integer K, sorts the array and using the method Array.BinSearch() finds the\nlargest number in the array which is <= K.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		int[] array = default(int[]);
		int? numberK = null;

		//Uncomment for testing
		//array = new[] { 1, 5, 2, 14, 78, 23, 144, -12, 3, -14, 100, 14, 14 };
		//array = new[] { 124, 512, 235, 14, 78, 23, 144, 22, 114, 100 };
		//array = new[] { -124, -512, -235, 14, -78, -23, -144, -22, -114, -100 };
		//array = new[] { 1, 5, 2, 14, 78, 23, 144, -12, 3, -14, 100 };
		//numberK = 14;

		if (array == null)
		{
			Console.WriteLine("Enter array of integers(1, 2, 3, 5, -1, 4): ");
			array = GetArrayFromConsole();
		}

		if (numberK == null)
		{
			Console.Write("Enter number K: ");
			numberK = int.Parse(Console.ReadLine());
		}

		Array.Sort(array);

		int indexOfK = Array.BinarySearch(array, numberK);

		Console.WriteLine("array:\n{0}", string.Join(", ", array));

		if (Array.LastIndexOf(array, numberK) > 0)
		{
			Console.WriteLine("Largest number <= K : {0}", indexOfK == 0 || indexOfK != Array.LastIndexOf(array, numberK) ? numberK : array[indexOfK - 1]);
		}
		else
		{
			Console.WriteLine("No element <= k");
		}
	}

	static int[] GetArrayFromConsole()
	{
		string input = Console.ReadLine();

		return input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();
	}
}
