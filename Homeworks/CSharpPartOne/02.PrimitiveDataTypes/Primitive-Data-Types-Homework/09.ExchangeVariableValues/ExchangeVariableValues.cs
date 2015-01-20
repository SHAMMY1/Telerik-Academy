//Problem 9. Exchange Variable Values

//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.

using System;

class ExchangeVariableValues
{
	static void Main()
	{
		string task = "Problem 9. Exchange Variable Values\n\nDeclare two integer variables a and b and assign them with 5 and 10 and\nafter that exchange their values by using some programming logic.\nPrint the variable values before and after the exchange.\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		int a = 5;
		int b = 10;

		Console.WriteLine("Before exchange:");
		Console.WriteLine("a = {0}", a);
		Console.WriteLine("b = {0}", b);
		Console.WriteLine();

		//Exchange logic
		int temp = a;
		a = b;
		b = temp;

		Console.WriteLine("After exchange:");
		Console.WriteLine("a = {0}", a);
		Console.WriteLine("b = {0}", b);
		Console.WriteLine();
	}
}
