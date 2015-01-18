//Problem 7. Print First and Last Name

//Create console application that prints your first and last name, each at a separate line.
using System;

class PrintFirstAndLastName
{
	static void Main()
	{
		string firstName = "FirstName";
		string lastName = "LasttName";

		string firstAndLastName = string.Format("{0}{1}{2}", firstName,Environment.NewLine,lastName);

		Console.WriteLine(firstAndLastName);
	}
}