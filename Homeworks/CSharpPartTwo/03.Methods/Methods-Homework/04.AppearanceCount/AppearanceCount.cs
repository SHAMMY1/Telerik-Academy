//Problem 4. Appearance count

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;
using System.Linq;

class AppearanceCount
{
	static void Main()
	{
		string task = "Problem 4. Appearance count\n\nWrite a method that counts how many times given number appears in given array.\nWrite a test program to check if the method is workings correctly.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter array(1, 2, 3, 4): ");

		int[] numbers = GetArrayFromConsole();

		Console.Write("Enetr number: ");

		int number = int.Parse(Console.ReadLine());

		Console.WriteLine("Array:\n{0}\nAppearances: {1}", string.Join(", ", numbers), AppearanceCounter(numbers,number));
	}

	private static int AppearanceCounter(int[] numbers, int number)
	{
		int count = 0;

		for (int i = 0; i < numbers.Length; i++)
		{
			if (numbers[i] == number)
			{
				count++;
			}
		}

		return count;
	}

	private static int[] GetArrayFromConsole()
	{
		string input = Console.ReadLine();
		char[] separators = { ' ', ',' };

		return input.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
	}
}
