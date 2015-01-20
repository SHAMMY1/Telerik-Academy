//Problem 7. Quotes in Strings

//Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
//Do the above in two different ways - with and without using quoted strings.
//Print the variables to ensure that their value was correctly defined.

using System;

class QuotesInStrings
{
	static void Main()
	{
		string task = "Problem 7. Quotes in Strings\n\nDeclare two string variables and assign them with following value: The \"use\"\nof quotations causes difficulties.\nDo the above in two different ways - with and without using quoted strings.\nPrint the variables to ensure that their value was correctly defined.\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		string quotedString = @"The ""use"" of quotations causes difficulties.";

		string notQuotedString = "The \"use\" of quotations causes difficulties.";

		Console.WriteLine("Quoted string: {0}", quotedString);
		Console.WriteLine();
		Console.WriteLine("Not quoted string: {0}", notQuotedString);
	}
}
