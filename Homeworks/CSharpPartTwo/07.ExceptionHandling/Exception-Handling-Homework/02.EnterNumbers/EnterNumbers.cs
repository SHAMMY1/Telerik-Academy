﻿//Problem 2. Enter numbers

//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

class EnterNumbers
{
	static void Main()
	{
		string task = "Problem 2. Enter numbers\n\nWrite a method ReadNumber(int start, int end) that enters an integer number in\na given range [start…end].\nIf an invalid number or non-number text is entered, the method should throw an\nexception.\nUsing this method write a program that enters 10 numbers: a1, a2, … a10, such\nthat 1 < a1 < … < a10 < 100\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
