//Problem 2. Get largest number

//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;
using System.Collections.Generic;

class GetlargestNumber
{
	static void Main()
	{
		string task = "Problem 2. Get largest number\n\nWrite a method GetMax() with two parameters that returns the larger of two\nintegers.\nWrite a program that reads 3 integers from the console and prints the largest\nof them using the method GetMax().\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		List<int> numbers = new List<int>();

		for (int i = 0; i < 3; i++)
		{
			Console.Write("Enetr number: ");
			numbers.Add(int.Parse(Console.ReadLine()));
		}

		int maxNumber = GetMax(GetMax(numbers[0],numbers[1]), numbers[2]);

		Console.WriteLine("\nNumbers: {0}\nMax number: {1}", string.Join(", ",numbers), maxNumber);
		
	}

	private static int GetMax(int first, int second)
	{
		return first > second ? first : second;
	}
}
