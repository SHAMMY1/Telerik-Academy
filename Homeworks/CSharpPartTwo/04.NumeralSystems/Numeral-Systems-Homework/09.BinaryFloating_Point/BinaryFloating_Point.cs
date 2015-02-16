//Problem 9.* Binary floating-point

//Write a program that shows the internal binary representation of given 32-bit signed floating-point number in
//IEEE 754 format (the C# type float).
//Example:

//number	sign	exponent	     mantissa
//-27,25	 1	    10000011	10110100000000000000000

using System;

class BinaryFloating_Point
{
	static void Main()
	{
		string task = "Problem 9.* Binary floating-point\n\nWrite a program that shows the internal binary representation of given\n32-bit signed floating-point number in IEEE 754 format (the C# type float).\nExample:\n\nnumber	sign	exponent	mantissa\n-27,25	 1	10000011	10110100000000000000000\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);
	}
}
