//Problem 12. Null Values Arithmetic

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.
using System;

class NullValuesArithmetic
{
	static void Main()
	{
		string task = "Problem 12. Null Values Arithmetic\n\nCreate a program that assigns null values\nto an integer and to a double variable.\nTry to print these variables at the console.\nTry to add some number or the null literal\nto these variables and print the result.\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		int? nullInteger = null;
		double? nullDouble = null;

		Console.WriteLine("Integer with null value:");
		Console.WriteLine(nullInteger);
		Console.WriteLine("Double wuth null value:");
		Console.WriteLine(nullDouble);

		Console.WriteLine("Adding null literal");
		Console.WriteLine();

		nullDouble += null;
		nullInteger += null;

		Console.WriteLine("Integer with null value:");
		Console.WriteLine(nullInteger);
		Console.WriteLine("Double wuth null value:");
		Console.WriteLine(nullDouble);

		Console.WriteLine("Adding number 3;");
		Console.WriteLine();

		nullDouble += 3;
		nullInteger += 3;

		Console.WriteLine("Integer with null value:");
		Console.WriteLine(nullInteger);
		Console.WriteLine("Double wuth null value:");
		Console.WriteLine(nullDouble);

	}
}
