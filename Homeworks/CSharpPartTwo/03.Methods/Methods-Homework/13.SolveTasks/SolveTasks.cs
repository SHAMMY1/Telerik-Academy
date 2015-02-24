//Problem 13. Solve tasks

//Write a program that can solve these tasks:
//   Reverses the digits of a number
//   Calculates the average of a sequence of integers
//   Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//   The decimal number should be non-negative
//   The sequence should not be empty
//   a should not be equal to 0

using System;
using System.Linq;

class SolveTasks
{
	static void Main()
	{
		string task = "Problem 13. Solve tasks\n\nWrite a program that can solve these tasks:\n   Reverses the digits of a number\n   Calculates the average of a sequence of integers\n   Solves a linear equation a * x + b = 0\nCreate appropriate methods.\nProvide a simple text-based menu for the user to choose which task to solve.\nValidate the input data:\n   The decimal number should be non-negative\n   The sequence should not be empty\n   a should not be equal to 0\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("\n1 -> Reverses the digits of a number\n2 -> Calculates the average of a sequence of integers\n3 -> Solves a linear equation a * x + b = 0\nChoose task: ");

		string taskToSolve = Console.ReadLine();

		switch (taskToSolve)
		{
			case "1":
				Console.Write("Enter Decimal number: ");
				decimal number = decimal.Parse(Console.ReadLine());
				Console.WriteLine("Reversee number: {0}", GetReversNumber(number));
				break;
			case "2":
				Console.WriteLine("Enter array(1, 2, 3, 4): ");

				int[] numbers = GetArrayFromConsole();

				Console.WriteLine("Average: {0}", GetAverage(numbers));
				break;
			case "3":
				Console.Write("Enter a: ");
				int a = int.Parse(Console.ReadLine());
				Console.Write("Enter b: ");
				int b = int.Parse(Console.ReadLine());

				Console.WriteLine("x = {0}", SolveEquation(a, b));
				break;
			default:
				Console.WriteLine("Wrong input!!!");
				break;
		}
	}

	private static decimal GetReversNumber(decimal number)
	{
		if (number < 0)
		{
			throw new ArithmeticException("Number should be non-negative!");
		}

		string reversNumberAsString = new string(number.ToString().Reverse().ToArray());

		return decimal.Parse(reversNumberAsString);
	}

	private static double GetAverage(params int[] set)
	{
		if (set.Length == 0)
		{
			throw new ArgumentNullException("set", "Set cannot be empty");
		}

		int sum = 0;

		foreach (var number in set)
		{
			sum += number;
		}

		return (double)sum / set.Length;
	}

	private static double SolveEquation(int A, int B)
	{
		if (A == 0)
		{
			throw new ArgumentException("Number A should not be equal to 0");
		}

		return (double)-B / A;
	}

	private static int[] GetArrayFromConsole()
	{
		string input = Console.ReadLine();
		char[] separators = { ' ', ',' };

		return input.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
	}
}
