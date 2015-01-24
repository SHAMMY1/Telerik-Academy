//Problem 11. Bitwise: Extract Bit #3

//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.
//Examples:

//n	  binary representation	bit #3
//5	    00000000 00000101	  0
//0	    00000000 00000000	  0
//15	00000000 00001111	  1
//5343	00010100 11011111	  1
//62241	11110011 00100001	  0

using System;

class ExtraxtBitThree
{
	static void Main()
	{
		string task = "Problem 11. Bitwise: Extract Bit #3\n\nUsing bitwise operators, write an expression for finding the value of the bit\n#3 of a given unsigned integer.\nThe bits are counted from right to left, starting from bit #0.\nThe result of the expression should be either 1 or 0.\nExamples:\nn	binary representation	bit #3\n5	00000000 00000101	0\n0	00000000 00000000	0\n15	00000000 00001111	1\n5343	00010100 11011111	1\n62241	11110011 00100001	0\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter number:");
		int number = int.Parse(Console.ReadLine());

		byte thirdBit = 0;

		if ((number & (1 << 3)) != 0)
		{
			thirdBit = 1;
		}

		string binaryNumber = Convert.ToString(number,2).PadLeft(16,'0');

		Console.WriteLine("number: {0}\nbinary representation: {1}\nbit#3: {2}", number, binaryNumber, thirdBit);
	}
}
