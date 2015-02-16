//Problem 1. Allocate array

//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

using System;

class AllocateArray
{
	static void Main()
	{
		string task = "Problem 1. Allocate array\n\nWrite a program that allocates array of 20 integers and initializes each\nelement by its index multiplied by 5.\nPrint the obtained array on the console.\n";


		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		int[] numbers = new int[20];

		for (int i = 0; i < numbers.Length; i++)
		{
			numbers[i] = i * 5;
		}

		foreach (var number in numbers)
		{
			Console.Write("{0} ", number);
		}

		Console.WriteLine("\n");
	}
}
