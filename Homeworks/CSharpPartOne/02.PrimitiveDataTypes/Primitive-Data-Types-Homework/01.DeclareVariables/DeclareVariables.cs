//Problem 1. Declare Variables

//Declare five variables choosing for each of them the most appropriate of the types 
//byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
//Submit the source code of your Visual Studio project as part of your homework submission.
using System;

class DeclareVariables
{
	static void Main()
	{
		string task = "Problem 1. Declare Variables\nDeclare five variables choosing for each of them the most appropriate\nof the types byte, sbyte, short, ushort, int, uint, long, ulong to represent\nthe following values: 52130, -115, 4825932, 97, -10000.\nChoose a large enough type for each number to ensure it will fit in it.\nTry to compile the code.\n";
		string separator = new string('*', Console.WindowWidth);
		Console.WriteLine(task);
		Console.WriteLine(separator);


		string messageModel = "Variable type: {0}\nValue: {1}\n";

		ushort ushortVariable = 52130;
		sbyte sbyteVariable = -115;
		int intVariable = 4825932;
		byte byteVariable = 97;
		short shortVariable = -10000;

		Console.WriteLine(messageModel, ushortVariable.GetType(), ushortVariable);
		Console.WriteLine(messageModel, sbyteVariable.GetType(), sbyteVariable);
		Console.WriteLine(messageModel, intVariable.GetType(), intVariable);
		Console.WriteLine(messageModel, byteVariable.GetType(), byteVariable);
		Console.WriteLine(messageModel, shortVariable.GetType(), shortVariable);
	}
}