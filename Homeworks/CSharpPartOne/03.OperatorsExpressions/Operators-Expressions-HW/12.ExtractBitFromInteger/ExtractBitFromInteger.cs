//Problem 12. Extract Bit from Integer

//Write an expression that extracts from given integer n the value of given bit at index p.
//Examples:

//n	  binary representation	  p   bit @ p
//5	    00000000 00000101	  2	    1
//0	    00000000 00000000	  9	    0
//15	00000000 00001111	  1	    1
//5343	00010100 11011111	  7	    1
//62241	11110011 00100001	  11	0

using System;

class ExtractBitFromInteger
{
	static void Main()
	{
		string task = "Problem 12. Extract Bit from Integer\n\nWrite an expression that extracts from given integer n the value of given bit\nat index p.\nExamples:\nn	binary representation	p	bit @ p\n5	00000000 00000101	2	1\n0	00000000 00000000	9	0\n15	00000000 00001111	1	1\n5343	00010100 11011111	7	1\n62241	11110011 00100001	11	0\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter number:");
		int number = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter index:");
		byte index = byte.Parse(Console.ReadLine());

		byte thirdBit = 0;

		if ((number & (1 << index)) != 0)
		{
			thirdBit = 1;
		}

		string binaryNumber = Convert.ToString(number, 2).PadLeft(16, '0');

		Console.WriteLine("number: {0}\nbinary representation: {1}\nindex: {2}\nbit @ p: {3}", number, binaryNumber,index, thirdBit);
	}
}
