//Problem 6. Maximal K sum

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;

class MaximalKSum
{
	static void Main(string[] args)
	{
		string task = "Problem 6. Maximal K sum\n\nWrite a program that reads two integer numbers N and K and an array of N\nelements from the console.\nFind in the array those K elements that have maximal sum.\n";


		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.Write("Enter number N: ");
		int numberN = int.Parse(Console.ReadLine());

		Console.Write("Enter number K: ");
		int numberK = int.Parse(Console.ReadLine());

		int[] numbers = new int[numberN];

		for (int i = 0; i < numbers.Length; i++)
		{
			Console.Write("Enter number: ");

			numbers[i] = int.Parse(Console.ReadLine());
		}

		Array.Sort(numbers);

		Array.Reverse(numbers);


		Console.Write("Elements: ");

		int sum = 0;

		for (int i = 0; i < numberK; i++)
		{
			Console.Write("{0} ", numbers[i]);
			sum += numbers[i];
		}
		Console.WriteLine("\nSum: {0}", sum);
	}
}
