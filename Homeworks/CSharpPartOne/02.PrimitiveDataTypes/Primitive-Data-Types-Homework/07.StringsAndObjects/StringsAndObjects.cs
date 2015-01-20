//Problem 6. Strings and Objects

//Declare two string variables and assign them with Hello and World.
//Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
//Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
using System;
using System.Linq.Expressions;

class StringsAndObjects
{
	static void Main()
	{
		string task = "Problem 6. Strings and Objects\n\nDeclare two string variables and assign them with Hello and World.Declare an\nobject variable and assign it with the concatenation of the first two variables (mind adding an interval between).Declare a third string variable and initializeit with the value of the object variable (you should perform type casting).\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		string hello = "Hello";
		string world = "World";

		object helloWorld = hello + " " + world;

		string helloWorldAsString = (string)helloWorld;

		Console.WriteLine("Variable type: {0}\nValue: {1}", helloWorldAsString.GetType(), helloWorldAsString);
	}

}