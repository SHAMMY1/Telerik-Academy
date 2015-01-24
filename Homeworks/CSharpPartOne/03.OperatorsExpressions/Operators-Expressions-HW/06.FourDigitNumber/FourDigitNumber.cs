//Problem 6. Four-Digit Number

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

//Examples:

//n	sum of digits	reversed	last digit in front	  second and third digits exchanged
//2011	 4	          1102	              1201	                    2101
//3333	 12	          3333	              3333	                    3333
//9876	 30	          6789	              6987	                    9786

using System;

class FourDigitNumber
{
	static void Main()
	{
		string task = "Problem 6. Four-Digit Number\n\nWrite a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:\nCalculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).\nPrints on the console the number in reversed order: dcba (in our example 1102).\nPuts the last digit in the first position: dabc (in our example 1201).\nExchanges the second and the third digits: acbd (in our example 2101).\nThe number has always exactly 4 digits and cannot start with 0.\nExamples:\nn	sum of digits	reversed	last digit in front	second and third digits exchanged\n2011	4	1102	1201	2101\n3333	12	3333	3333	3333\n9876	30	6789	6987	9786\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter number:");
		int number = int.Parse(Console.ReadLine());

		int firstDigit = number % 10;
		int secondDigit = number / 10 % 10;
		int thirdDigit = number / 100 % 10;
		int fourthDigit = number / 1000 % 10;

		int sumOfDigits = firstDigit + secondDigit + thirdDigit + fourthDigit;

		int reversedNumber = fourthDigit + (thirdDigit * 10) + (secondDigit * 100) + (firstDigit * 1000);

		int lastDigitInFront = secondDigit + (thirdDigit * 10) + (fourthDigit * 100) + (firstDigit * 1000);

		int secondAndThirdDigitsExchanged = firstDigit + (thirdDigit * 10) + (secondDigit * 100) + (fourthDigit * 1000);

		Console.WriteLine("n: {0}\nsum of digits: {1}\nreversed: {2}\nlast digit in front: {3}\nsecond and third digits exchanged: {4}", number, sumOfDigits, reversedNumber,lastDigitInFront, secondAndThirdDigitsExchanged);
	}
}
