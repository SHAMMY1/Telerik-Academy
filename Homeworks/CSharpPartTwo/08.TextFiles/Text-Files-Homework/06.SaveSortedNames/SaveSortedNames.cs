//Problem 6. Save sorted names

//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
//Example:

//input.txt	output.txt
//Ivan        George
//Peter       Ivan
//Maria       Maria
//George      Peter	 
 
 


using System;

class SaveSortedNames
{
	static void Main()
	{
		string task = "Problem 6. Save sorted names\n\nWrite a program that reads a text file containing a list of strings, sorts them and saves them to another text file.\nExample:\n\ninput.txt   output.txt\nIvan        George\nPeter       Ivan\nMaria       Maria\nGeorge      Peter	\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
