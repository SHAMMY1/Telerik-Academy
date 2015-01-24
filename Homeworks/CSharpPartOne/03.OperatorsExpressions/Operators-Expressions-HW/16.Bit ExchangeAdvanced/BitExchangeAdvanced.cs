//Problem 16.** Bit Exchange (Advanced)

//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
//The first and the second sequence of bits may not overlap.
//Examples:

//n	             p	  q	    k	    binary representation of n	                   binary result	             result
//1140867093	 3	  24	3	01000100 00000000 01000000 00010101	    01000010 00000000 01000000 00100101	   1107312677
//4294901775	 24	  3	    3	11111111 11111111 00000000 00001111	    11111001 11111111 00000000 00111111	   4194238527
//2369124121	 2	  22	10	10001101 00110101 11110111 00011001	    01110001 10110101 11111000 11010001	   1907751121
//987654321	     2	  8	    11	                   -	                                  -	                   overlapping
//123456789	     26	  0	    7	                   -	                                  -	                   out of range
//33333333333	-1	  0	    33	                   -	                                  -	                   out of range

using System;

class BitExchangeAdvanced
{
	static void Main()
	{
		string task = "Problem 16.** Bit Exchange (Advanced)\n\nWrite a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.\nThe first and the second sequence of bits may not overlap.\nExamples:\nn	        p	q	k	result\n1140867093	3	24	3	1107312677\n4294901775	24	3	3	4194238527\n2369124121	2	22	10	1907751121\n987654321	2	8	11	overlapping\n123456789	26	0	7	out of range\n33333333333	-1	0	33	out of range\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter Unsigned integer:");
		string numberAsString = Console.ReadLine();
		uint result , number;

		Console.WriteLine("Enter p:");
		int p = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter q:");
		int q = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter k:");
		int k = int.Parse(Console.ReadLine());

		if (!uint.TryParse(numberAsString,out number))
		{
			Console.WriteLine("out of range");
		}
		else if ((Math.Min(p, q) + k) >= Math.Max(p, q)) 
		{
			Console.WriteLine("out of range");
		}
		else if ((Math.Min(p,q) < 0) || ((Math.Max(p,q) + k - 1) > 31)) 
		{
			Console.WriteLine("overlapping");
		}
		else
		{
			uint mask = 0;

			for (int i = 0; i < k; i++)
			{
				bool isBitsSame = ((number & (1 << (p + i))) != 0) == ((number & (1 << (q + i))) != 0);

				if (!isBitsSame)
				{
					mask |= ((uint)(1 << (p + i)) | (uint)(1 << (q + i)));
				}
			}
			result = number ^ mask;
			Console.WriteLine();
			Console.WriteLine("Mask:   {0}", Convert.ToString(mask, 2).PadLeft(32, '0'));
			Console.WriteLine("Number: {0}\nResult: {1}", Convert.ToString(number, 2).PadLeft(32, '0'), Convert.ToString(result, 2).PadLeft(32, '0'));
			Console.WriteLine();
			Console.WriteLine("Number: {0}\nResult: {1}", number, result);
		}
	}
}
