//Problem 2. Compare arrays

//Write a program that reads two integer arrays from the console and compares them element by element.

using System;
using System.Linq;

class CompareArrays
{
	static void Main()
	{
		string task = "Problem 2. Compare arrays\n\nWrite a program that reads two integer arrays from the console and compares\nthem element by element.\n";


		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter first array(1, 2, 3, 4): ");
		int[] firstArray = GetsArrayFromConsole();

		Console.WriteLine("Enter second array(1, 2, 3, 4): ");
		int[] secondArray = GetsArrayFromConsole();

		bool areEqual = true;

		if (firstArray.Length != secondArray.Length)
		{
			areEqual = false;
		}
		else
		{
			for (int i = 0; i < firstArray.Length; i++)
			{
				if (firstArray[i] != secondArray[i])
				{
					areEqual = false;
					break;
				}
			}
		}

		Console.WriteLine("Are the arrays equal: {0}", areEqual);
	}

	private static int[] GetsArrayFromConsole()
	{
		string input = Console.ReadLine();
		char[] separators = { ' ', ',' };

		return input.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
	}
}
