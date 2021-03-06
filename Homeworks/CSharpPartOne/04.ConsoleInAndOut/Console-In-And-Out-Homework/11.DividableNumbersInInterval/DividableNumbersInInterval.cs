﻿//Problem 11.* Numbers in Interval Dividable by Given Number

//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that
//the reminder of the division by 5 is 0.
//Examples:

//start	end	   p	comments
//17	25	   2	20, 25
//5	    30	   6	5, 10, 15, 20, 25, 30
//3	    33	   6	5, 10, 15, 20, 25, 30
//3	    4	   0	-
//99	120	   5	100, 105, 110, 115, 120
//107	196	   18	110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170, 175, 180, 185, 190, 195

using System;

class DividableNumbersInInterval
{
	static void Main()
	{
		string task = "Problem 11.* Numbers in Interval Dividable by Given Number\n\nWrite a program that reads two positive integer numbers and prints how many\nnumbers p exist between them such that the reminder of the division by 5 is 0.\nExamples:\nstart	end	p	comments\n17	25	2	20, 25\n5	30	6	5, 10, 15, 20, 25, 30\n3	33	6	5, 10, 15, 20, 25, 30\n3	4	0	-\n99	120	5	100, 105, 110, 115, 120\n107	196	18	110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160,\n                        165, 170, 175, 180, 185, 190, 195\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.Write("Enter start: ");
		uint start = uint.Parse(Console.ReadLine());

		Console.Write("Enter end: ");
		uint end = uint.Parse(Console.ReadLine());
		uint count = 0;

		while (start % 5 != 0)
		{
			start++;
		}

		do
		{
			count++;
			start += 5;
		} 
		while (start <= end);

		Console.WriteLine("p: {0}", count);
	}
}
