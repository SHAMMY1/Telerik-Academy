//Problem 9.* Binary floating-point

//Write a program that shows the internal binary representation of given 32-bit signed floating-point number in
//IEEE 754 format (the C# type float).
//Example:

//number	sign	exponent	     mantissa
//-27,25	 1	    10000011	10110100000000000000000

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class BinaryFloating_Point
{
	static void Main()
	{
		string task = "Problem 9.* Binary floating-point\n\nWrite a program that shows the internal binary representation of given\n32-bit signed floating-point number in IEEE 754 format (the C# type float).\nExample:\n\nnumber	sign	exponent	mantissa\n-27.25	 1	10000011	10110100000000000000000\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.Write("Enter 32-bit signed floating-point: ");
		float number = float.Parse(Console.ReadLine());

		var result = FloatToBinary(number);

		Console.WriteLine("sign: {0}\nexponent: {1}\nmantissa: {2}", result[0], result[1], result[2]);

	}


	private static string[] FloatToBinary(float number)
	{
		string[] result = new string[3];

		string binary = string.Join("", BitConverter.GetBytes(number)
													.Reverse()
													.Select(s => Convert.ToString(s, 2).PadLeft(8,'0')));

		result[0] = binary[0].ToString();
		result[1] = binary.ToString().Substring(1, 8);
		result[2] = binary.ToString().Substring(9);

		return result;
	}

	
 
}
