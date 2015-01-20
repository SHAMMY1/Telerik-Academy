//Problem 2. Float or Double?

//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 
//34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.
using System;

class  FloatOrDouble
{
	static void Main()
	{
		string task = "Problem 2. Float or Double?\n\nWhich of the following values can be assigned to a variable of type float and\nwhich to a variable of type double:\n34.567839023, 12.345, 8923.1234857, 3456.091?\nWrite a program to assign the numbers in variables and print them to ensure\nno precision is lost.\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		string messageModel = "Variable type: {0}\nValue: {1}\n";

		double firstNumber = 34.567839023;
		float secondNumber = 12.345F;
		double thirdNumber = 8923.1234857;
		float fourthNumber = 3456.091F;

		Console.WriteLine(messageModel, firstNumber.GetType(), firstNumber);
		Console.WriteLine(messageModel, secondNumber.GetType(), secondNumber);
		Console.WriteLine(messageModel, thirdNumber.GetType(), thirdNumber);
		Console.WriteLine(messageModel, fourthNumber.GetType(), fourthNumber);
	}
}