//Problem 3. Divide by 7 and 5

//Write a Boolean expression that checks for given integer if it can be divided (without remainder)
//by 7 and 5 at the same time.
//Examples:

//n	Divided by 7 and 5?
//3	    false
//0	    true
//5	    false
//7	    false
//35	true
//140	true

using System;

class DivideBySevenAndFive
{
	static void Main()
	{
		string task = "Problem 3. Divide by 7 and 5\n\nWrite a Boolean expression that checks for given integer if it can be divided\n(without remainder) by 7 and 5 at the same time.\nExamples:\nn	Divided by 7 and 5?\n3	false\n0	true\n5	false\n7	false\n35	true\n140	true\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter number:");
		int number = int.Parse(Console.ReadLine());

		bool isDivisibleBySevenAndFive = (number % 7 == 0) && (number % 5 == 0);

		Console.WriteLine("Is {0} dividible by seven and five: {1}", number, isDivisibleBySevenAndFive);
	}
}
