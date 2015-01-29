//Problem 5. Formatting Numbers

//Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.
//Examples:

//a	     b	         c	           result
//254	11.6	   0.5	     FE |0011111110| 11.60|0.500 |
//499	-0.5559	   10000	 1F3|0111110011| -0.56|10000.000 |
//0	    3	       -0.1234	 0  |0000000000| 3.00 |-0.123 |

using System;

class FormattingNumbers
{
	static void Main()
	{
		string task = "Problem 5. Formatting Numbers\n\nWrite a program that reads 3 numbers:\ninteger a (0 <= a <= 500)\nfloating-point b\nfloating-point c\nThe program then prints them in 4 virtual columns on the console.\nEach column should have a width of 10 characters.\nThe number a should be printed in hexadecimal, left aligned\nThen the number a should be printed in binary form, padded with zeroes\nThe number b should be printed with 2 digits after the decimal point,\nright aligned\nThe number c should be printed with 3 digits after the decimal point,\nleft aligned.\nExamples:\na	b	c	result\n254	11.6	0.5	FE |0011111110| 11.60|0.500 |\n499	-0.5559	10000	1F3 |0111110011| -0.56|10000.000 |\n0	3	-0.1234	0 |0000000000| 3.00|-0.123 |\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.Write("Enter integer: ");
		int numberA = int.Parse(Console.ReadLine());

		Console.Write("Enter first floating-point: ");
		double numberB = double.Parse(Console.ReadLine());

		Console.Write("Enter second floating-point: ");
		double numberC = double.Parse(Console.ReadLine());

		string result = string.Format("|{0}|{1}|{2}|{3}|", Convert.ToString(numberA, 16).ToUpper().PadRight(10)
														 , Convert.ToString(numberA, 2).ToUpper().PadLeft(10, '0')
														 , numberB.ToString("F2").PadLeft(10)
														 ,numberC.ToString("F3").PadRight(10));

		Console.WriteLine("Result:\n{0}", result);

	}
}
