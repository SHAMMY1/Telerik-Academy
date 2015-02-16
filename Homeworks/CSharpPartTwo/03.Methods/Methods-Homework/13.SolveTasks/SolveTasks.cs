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

class SolveTasks
{
	static void Main()
	{
		string task = "Problem 13. Solve tasks\n\nWrite a program that can solve these tasks:\n   Reverses the digits of a number\n   Calculates the average of a sequence of integers\n   Solves a linear equation a * x + b = 0\nCreate appropriate methods.\nProvide a simple text-based menu for the user to choose which task to solve.\nValidate the input data:\n   The decimal number should be non-negative\n   The sequence should not be empty\n   a should not be equal to 0\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);
	}
}
