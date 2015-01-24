//Problem 15.* Bits Exchange

//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
//Examples:

//n	              binary representation of n	              binary result	                      result
//1140867093	01000100 00000000 01000000 00010101	    01000010 00000000 01000000 00100101	     1107312677
//255406592	    00001111 00111001 00110010 00000000	    00001000 00111001 00110010 00111000	     137966136
//4294901775	11111111 11111111 00000000 00001111	    11111001 11111111 00000000 00111111	     4194238527
//5351	        00000000 00000000 00010100 11100111	    00000100 00000000 00010100 11000111	     67114183
//2369124121	10001101 00110101 11110111 00011001	    10001011 00110101 11110111 00101001	     2335569705

using System;

class BitsExchange
{
	static void Main()
	{
		string task = "Problem 15.* Bits Exchange\n\nWrite a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.\nExamples:\nn		result\n1140867093	1107312677\n255406592	137966136\n4294901775	4194238527\n5351	        67114183\n2369124121	2335569705\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter Unsigned integer:");
		uint number = uint.Parse(Console.ReadLine());
		uint result = number;
		for (int i = 0; i < 3; i++)
		{
			bool isBitsSame = ((number & (1 << (3 + i))) != 0) == ((number & (1 << (24 + i))) != 0);

			if (!isBitsSame)
			{
				uint mask = ((uint)(1 << (3 + i)) | (uint)(1 << (24 + i)));
				result = result ^ mask;

				Console.WriteLine("Mask:   {0}",Convert.ToString(mask, 2).PadLeft(32, '0'));
			}
			Console.WriteLine("Number: {0}\nResult: {1}", Convert.ToString(number, 2).PadLeft(26, '0'), Convert.ToString(result, 2).PadLeft(26, '0'));
			Console.WriteLine();
		}

		Console.WriteLine("Number: {0}\nResult: {1}", number, result);
	}
}
