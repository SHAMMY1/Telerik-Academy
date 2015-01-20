//Problem 8. Isosceles Triangle

//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©

//  © ©

// ©   ©

//© © © ©

using System;
using System.Text;

class IsoscelesTriangle
{
	static void Main()
	{
		Encoding currentEncoding= Console.OutputEncoding;

		Console.OutputEncoding = Encoding.UTF8;
		
		string task = "Problem 8. Isosceles Triangle\n\nWrite a program that prints an isosceles triangle of 9 copyright symbols ©,\nsomething like this:\n   ©\n  © ©\n ©   ©\n© © © ©\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		string triangle = "\n\n   ©\n  © ©\n ©   ©\n© © © ©\n";

		Console.OutputEncoding = currentEncoding;
		Console.WriteLine("Triangle without UTF-8 encoding: {0}", triangle);
		Console.OutputEncoding = Encoding.UTF8;
		Console.Write("Triangle with UTF-8 encoding: {0}", triangle); 
		Console.OutputEncoding = currentEncoding;

	}
}
