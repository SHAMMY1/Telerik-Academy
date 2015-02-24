//Problem 5. Parse tags

//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;

class ParseTags
{
	static void Main()
	{
		string task = "Problem 5. Parse tags\n\nYou are given a text. Write a program that changes the text in all regions\nsurrounded by the tags <upcase> and </upcase> to upper-case.\nThe tags cannot be nested.\nExample:\nWe are living in a <upcase>yellow submarine</upcase>.We don't have <upcase>anything</upcase> else.\n\nThe expected result:\nWe are living in a YELLOW SUBMARINE.We don't have ANYTHING else.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
