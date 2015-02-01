//Problem 9. Play with Int, Double and String

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.
//Example 1:

//program	                user
//Please choose a type:	
//1 --> int	
//2 --> double	
//3 --> string	            3
//Please enter a string:	hello
//hello*	
//Example 2:

//program	                user
//Please choose a type:	
//1 --> int	
//2 --> double	            2
//3 --> string	
//Please enter a double:	1.5
//2.5	

using System;

class PlayWithIntDoubleAndString
{
	static void Main()
	{
		string task = "Problem 9. Play with Int, Double and String\n\nWrite a program that, depending on the user’s choice, inputs an int, double or string variable.\nIf the variable is int or double, the program increases it by one.\nIf the variable is a string, the program appends * at the end.\nPrint the result at the console. Use switch statement.\nExample 1:\nprogram	user\nPlease choose a type:	\n1 --> int	\n2 --> double	\n3 --> string	3\nPlease enter a string:	hello\nhello*	\nExample 2:\nprogram	user\nPlease choose a type:	\n1 --> int	\n2 --> double	2\n3 --> string	\nPlease enter a double:	1.5\n2.5	\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.Write("1 --> int\n2 --> double\n3 --> string\nPlease choose a type: ");
		string choice = Console.ReadLine();

		switch (choice)
		{
			case "1": choice = "int"; break;
			case "2": choice = "double"; break;
			case "3": choice = "string"; break;
			default:
				break;
		}

		Console.Write("Please enter a {0}: ", choice);
		string input = Console.ReadLine();
		Console.Write("Result: ");

		switch (choice)
		{
			case "int": Console.WriteLine(int.Parse(input) + 1); break;
			case "double": Console.WriteLine(double.Parse(input) + 1); break;
			case "string": Console.WriteLine(input + '*'); break;
			default: Console.WriteLine("Invalid choice"); break;
		}

	}
}
