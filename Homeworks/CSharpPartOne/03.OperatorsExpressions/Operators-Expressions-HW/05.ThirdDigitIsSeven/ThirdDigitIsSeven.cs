//Problem 5. Third Digit is 7?

//Write an expression that checks for given integer if its third digit from right-to-left is 7.
//Examples:

//  n	 Third digit 7?
//5	        false
//701	    true
//9703      true
//877	    false
//777877	false
//9999799	true

using System;

class ThirdDigitIsSeven
{
	static void Main()
	{
		string task = "Problem 5. Third Digit is 7?\n\nWrite an expression that checks for given integer if its third digit from\nright-to-left is 7.\nExamples:\nn	Third digit 7?\n5	false\n701	true\n9703	true\n877	false\n777877	false\n9999799	true\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter number:");
		int number =int.Parse(Console.ReadLine());

		byte digitToCompare = 7;

		byte thirdDigit = (byte)((Math.Abs(number) / 100) % 10);

		bool isThirdDigitSeven = thirdDigit == digitToCompare;

		Console.WriteLine("Is third digit in {0} seven: {1}", number, isThirdDigitSeven);
	}
}
