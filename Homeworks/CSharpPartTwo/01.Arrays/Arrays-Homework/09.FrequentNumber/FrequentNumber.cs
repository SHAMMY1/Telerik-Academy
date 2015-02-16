//Problem 9. Frequent number

//Write a program that finds the most frequent number in an array.
//Example:

//input	                                  result
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	  4 (5 times)

using System;
using System.Collections.Generic;
using System.Linq;

class FrequentNumber
{
	static void Main()
	{
		string task = "Problem 9. Frequent number\n\nWrite a program that finds the most frequent number in an array.\nExample:\ninput	                                result\n4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	4 (5 times)\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter array(1, 2, 3, 4): ");
		int[] array = GetsArrayFromConsole();

		var reps = new Dictionary<int, int>();

		for (int i = 0; i < array.Length; i++)
		{
			if (!reps.ContainsKey(array[i]))
			{
				reps[array[i]] = 1;
			}
			else
			{
				reps[array[i]]++;
			}
		}

		int maxReps = 0;
		int mostFreqNumber = 0;
		foreach (var number in reps)
		{
			if (maxReps < number.Value)
			{
				maxReps = number.Value;
				mostFreqNumber = number.Key;
			}
		}

		Console.WriteLine("{0}({1} times)", mostFreqNumber,maxReps);
	}

	private static int[] GetsArrayFromConsole()
	{
		string input = Console.ReadLine();
		char[] separators = { ' ', ',' };

		return input.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
	}
}
