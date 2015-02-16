//Problem 1. Say Hello

//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.
//Example:

//input	  output
//Peter	  Hello, Peter!

using System;

class SayHello
{
	static void Main()
	{
		string task = "Problem 1. Say Hello\n\nWrite a method that asks the user for his name and prints “Hello, <name>”\nWrite a program to test this method.\nExample:\ninput	output\nPeter	Hello, Peter!\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);
	}
}
