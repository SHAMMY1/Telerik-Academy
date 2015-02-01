//Problem 3. Check for a Play Card

//Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.
//Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. 

//Examples:
//character	    Valid card sign?
//5	                 yes
//1	                 no
//Q	                 yes
//q	                 no
//P	                 no
//10	             yes
//500	             no

using System;
using System.Linq;

class CheckForAPlayCard
{
	static void Main()
	{
		string task = "Problem 3. Check for a Play Card\n\nClassical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and\nprints “yes” if it is a valid card sign or “no” otherwise.\n\nExamples:\ncharacter	Valid card sign?\n5	yes\n1	no\nQ	yes\nq	no\nP	no\n10	yes\n500	no\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.Write("Enter string: ");
		string input = Console.ReadLine();

		string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

		bool isCard = cards.Contains(input);

		Console.WriteLine("Is valid card sign: {0}", isCard ? "yes" : "no");

	}
}
