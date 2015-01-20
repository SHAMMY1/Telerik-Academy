//Problem 3. Variable in Hexadecimal Format

//Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
//Use Windows Calculator to find its hexadecimal representation.
//Print the variable and ensure that the result is 254.

using System;

class VariableInHexadecimalFormat
{
	static void Main()
	{
		string task = "Problem 3. Variable in Hexadecimal Format\n\nDeclare an integer variable and assign it with the value 254\nin hexadecimal format (0x##).\nUse Windows Calculator to find its hexadecimal representation.\nPrint the variable and ensure that the result is 254.\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		string numberInHexadecimal = "0xFE";

		int number = Convert.ToInt32(numberInHexadecimal,16);

		Console.WriteLine("Number in hexadecimal format: {0}\nVariable value: {1}", numberInHexadecimal, number);
	}
}