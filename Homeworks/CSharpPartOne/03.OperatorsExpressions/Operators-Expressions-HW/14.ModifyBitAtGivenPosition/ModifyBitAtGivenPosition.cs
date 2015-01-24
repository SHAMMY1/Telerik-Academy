//Problem 14. Modify a Bit at Given Position

//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p 
//from the binary representation of n while preserving all other bits in n.
//Examples:

//n binary representation of n  p	    v	   binary result	result
//5	    00000000 00000101	      2	    0	00000000 00000001	  1
//0	    00000000 00000000	      9	    1	00000010 00000000	  512
//15	00000000 00001111	      1	    1	00000000 00001111	  15
//5343  00010100 11011111	      7	    0	00010100 01011111	  5215
//62241 11110011 00100001	      11	0	11110011 00100001	  62241

using System;

class ModifyBitAtGivenPosition
{
	static void Main()
	{
		string task = "Problem 14. Modify a Bit at Given Position\n\nWe are given an integer number n, a bit value v (v=0 or 1) and a position p.\nWrite a sequence of operators (a few lines of C# code) that modifies n to hold\nthe value v at the position p from the binary representation of n while\npreserving all other bits in n.\nExamples:\nn  binary representation of n	p	v	binary result	      result\n5	00000000 00000101	2	0	00000000 00000001	1\n0	00000000 00000000	9	1	00000010 00000000	512\n15	00000000 00001111	1	1	00000000 00001111	15\n5343	00010100 11011111	7	0	00010100 01011111	5215\n62241	11110011 00100001	11	0	11110011 00100001	62241\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter number:");
		int number = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter position:");
		int position = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter value:");
		int value = int.Parse(Console.ReadLine());

		int result = (number & ~(1 << position)) | (value << position);

		Console.WriteLine("number: {0}    result: {1}", number, result);
	}
}
