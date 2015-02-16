//Problem 11. Binary search

//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;
using System.Linq;

class BinarySearch
{
	static int[] array;
	static int number;
	static int position;
	static bool notFound = true;

	static void Main(string[] args)
	{
		string task = "Problem 11. Binary search\n\nWrite a program that finds the index of given element in a sorted array of\nintegers by using the Binary search algorithm.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		InitializingArray();

		FindNumber();

		PrintResult();

	}

	private static void FindNumber()
	{
		int maxIndex = array.Length - 1;
		int minIndex = 0;
		int tempIndex = maxIndex / 2;
		do
		{
			if (array[tempIndex] == number)
			{
				notFound = false;
				break;
			}
			else if (array[tempIndex] < number)
			{
				minIndex = tempIndex + 1;
				tempIndex = (maxIndex + minIndex) / 2;
			}
			else
			{
				maxIndex = tempIndex - 1;
				tempIndex = (maxIndex + minIndex) / 2;

			}
		}
		while (minIndex != maxIndex);
		position = tempIndex;
	}

	private static void PrintResult()
	{
		if (notFound)
		{
			Console.WriteLine("Not found");
		}
		else
		{
			Console.WriteLine("Found at position {0}", position);
		}

	}

	private static void InitializingArray()
	{

		Console.WriteLine("Enter sorted array (1,4,5,7) :");

		string inputArrayOne = Console.ReadLine();

		char[] delimiter = new char[] { ',', ' ' };

		string[] inputOne = inputArrayOne.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

		array = new int[inputOne.Length];

		for (int i = 0; i < inputOne.Length; i++)
		{
			array[i] = int.Parse(inputOne[i]);
		}

		Console.WriteLine("Enter number:");

		number = int.Parse(Console.ReadLine());

		Console.WriteLine();

	}
}
