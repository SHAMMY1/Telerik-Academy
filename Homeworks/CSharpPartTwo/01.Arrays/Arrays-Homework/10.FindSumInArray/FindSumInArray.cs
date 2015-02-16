//Problem 10. Find sum in array

//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:

//array	                   S	result
//4, 3, 1, 4, 2, 5, 8	   11	4, 2, 5

using System;
using System.Linq;

class FindSumInArray
{
	static int[] array;
	static int sumS;
	static bool present;
	static int position;
	static int subLenght;

	static void Main(string[] args)
	{
		string task = "Problem 10. Find sum in array\n\nWrite a program that finds in given array of integers a sequence of given sum S (if present).\nExample:\narray	                S	result\n4, 3, 1, 4, 2, 5, 8	11	4, 2, 5\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		InitializingArray();

		FindSequence();

		PrintResult();
	}

	private static void PrintResult()
	{
		if (!present)
		{
			Console.WriteLine("There is no sequence of given sum!");
		}
		else
		{
			Console.WriteLine("Sequence of given sum is present:");

			for (int i = position; i <= position + subLenght; i++)
			{
				Console.Write("{0} ", array[i]);



			}
			Console.WriteLine();
		}
	}

	private static void FindSequence()
	{
		int sum;
		for (int i = 0; i < array.Length; i++)
		{
			sum = 0;
			for (int j = i; j < array.Length; j++)
			{
				sum += array[j];
				if (sum == sumS)
				{
					present = true;
					position = i;
					subLenght = j - i;
					return;
				}
			}
		}
		present = false;
		return;
	}

	private static void InitializingArray()
	{
		Console.Write("Enter sum S: ");
		sumS = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter array (2,1,4,1,5,7) :");

		string inputArrayOne = Console.ReadLine();

		char[] delimiter = new char[] { ',', ' ' };

		string[] inputOne = inputArrayOne.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

		array = new int[inputOne.Length];

		for (int i = 0; i < inputOne.Length; i++)
		{
			array[i] = int.Parse(inputOne[i]);
		}

		Console.WriteLine();

	}
}
