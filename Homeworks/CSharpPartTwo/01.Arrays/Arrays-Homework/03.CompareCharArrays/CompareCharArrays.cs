//Problem 3. Compare char arrays

//Write a program that compares two char arrays lexicographically (letter by letter).

using System;
using System.Linq;

class CompareCharArrays
{
	static void Main()
	{
		string task = "Problem 3. Compare char arrays\n\nWrite a program that compares two char arrays lexicographically\n(letter by letter).\n";


		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter first array(a, b, c, d): ");
		char[] firstArray = GetsArrayFromConsole();

		Console.WriteLine("Enter second array(a, b, c, d): ");
		char[] secondArray = GetsArrayFromConsole();

		bool firstIsFirst = true;


		for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
		{
			if (firstArray[i] > secondArray[i])
			{
				firstIsFirst = false;
				break;
			}
		}

		Console.WriteLine("First array: {0}", firstIsFirst ? "First" : "Second");
	}

	private static char[] GetsArrayFromConsole()
	{
		string input = Console.ReadLine();
		char[] separators = { ' ', ',' };

		return input.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(x => char.Parse(x)).ToArray();
	}
}

	
