//Problem 8. Digit as Word

//Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
//Print “not a digit” in case of invalid input.
//Use a switch statement.
//Examples:

//d	    result
//2	    two
//1	    one
//0	    zero
//5	    five
//-0.1	not a digit
//hi	not a digit
//9	    nine
//10	not a digit

using System;

class DigitAsWord
{
	static void Main()
	{
		string task = "Problem 8. Digit as Word\n\nWrite a program that asks for a digit (0-9), and depending on the input, shows\nthe digit as a word (in English).\nPrint “not a digit” in case of invalid input.\nUse a switch statement.\nExamples:\nd	result\n2	two\n1	one\n0	zero\n5	five\n-0.1	not a digit\nhi	not a digit\n9	nine\n10	not a digit\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.Write("Enter digit: ");
		string input = Console.ReadLine();
		string result;

		switch (input)
		{
			case "1": result = "one"; break;
			case "2": result = "two"; break;
			case "3": result = "three"; break;
			case "4": result = "four"; break;
			case "5": result = "five"; break;
			case "6": result = "six"; break;
			case "7": result = "seven"; break;
			case "8": result = "eight"; break;
			case "9": result = "nine"; break;
			case "0": result = "zero"; break;
			default: result = "not a digit";
				break;
		}

		Console.WriteLine(result);
	}
}
