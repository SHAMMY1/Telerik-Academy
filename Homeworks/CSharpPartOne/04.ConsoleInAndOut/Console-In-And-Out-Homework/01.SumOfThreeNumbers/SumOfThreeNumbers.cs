﻿//Problem 1. Sum of 3 Numbers

//Write a program that reads 3 real numbers from the console and prints their sum.
//Examples:

//a	    b	 c	   sum
//3	    4	 11	   18
//-2	0	 3	   1
//5.5	4.5	 20.1  30.1

using System;

class SumOfThreeNumbers
{
	static void Main()
	{
		string task = "Problem 1. Sum of 3 Numbers\n\nWrite a program that reads 3 real numbers from the console and prints their sum.\nExamples:\na	b	c	sum\n3	4	11	18\n-2	0	3	1\n5.5	4.5	20.1	30.1\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);
	}
}
