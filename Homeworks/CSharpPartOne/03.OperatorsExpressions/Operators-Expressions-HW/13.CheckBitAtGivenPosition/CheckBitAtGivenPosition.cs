//Problem 13. Check a Bit at Given Position

//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in 
//given integer number n, has value of 1.
//Examples:

//n	  binary representation of n	p	bit @ p == 1
//5	    00000000 00000101	        2	   true
//0	    00000000 00000000	        9	   false
//15	00000000 00001111	        1	   true
//5343	00010100 11011111	        7	   true
//62241	11110011 00100001	        11	   false

using System;

class CheckBitAtGivenPosition
{
	static void Main()
	{
		string task = "Problem 13. Check a Bit at Given Position\n\nWrite a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.\nExamples:\nn binary representation of n	p	bit @ p == 1\n5	00000000 00000101	2	true\n0	00000000 00000000	9	false\n15	00000000 00001111	1	true\n5343	00010100 11011111	7	true\n62241	11110011 00100001	11	false\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter number:");
		int number = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter index:");
		byte index = byte.Parse(Console.ReadLine());

		bool isBitOne = (number & (1 << index)) != 0;

		string binaryNumber = Convert.ToString(number, 2).PadLeft(16, '0');

		Console.WriteLine("number: {0}\nbinary representation: {1}\nindex: {2}\nbit @ p == 1: {3}", number, binaryNumber, index, isBitOne);

	}
}
