﻿//Problem 7.* Arithmetical expressions

//Write a program that calculates the value of given arithmetical expression.
//The expression can contain the following elements only:
//Real numbers, e.g. 5, 18.33, 3.14159, 12.6
//Arithmetic operators: +, -, *, / (standard priorities)
//Mathematical functions: ln(x), sqrt(x), pow(x,y)
//Brackets (for changing the default priorities): (, )
//Examples:

//input	                                                output
//(3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7)	            ~10.6
//pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3)	~21.22

using System;

class ArithmeticalExpressions
{
	static void Main()
	{
		string task = "Problem 7.* Arithmetical expressions\n\nWrite a program that calculates the value of given arithmetical expression.\nThe expression can contain the following elements only:\nReal numbers, e.g. 5, 18.33, 3.14159, 12.6\nArithmetic operators: +, -, *, / (standard priorities)\nMathematical functions: ln(x), sqrt(x), pow(x,y)\nBrackets (for changing the default priorities): (, )\nExamples:\n\ninput	                                                output\n(3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7)	                ~10.6\npow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3)	~21.22\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
