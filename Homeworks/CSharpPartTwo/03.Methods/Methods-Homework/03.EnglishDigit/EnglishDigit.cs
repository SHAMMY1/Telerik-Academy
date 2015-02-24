//Problem 3. English digit

//Write a method that returns the last digit of given integer as an English word.
//Examples:

//input	 output
//512	 two
//1024	 four
//12309	 nine

using System;

class EnglishDigit
{
	static void Main()
	{
		string task = "Problem 3. English digit\nWrite a method that returns the last digit of given integer as an English word.\nExamples:\n\ninput	output\n512	two\n1024	four\n12309	nine\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.Write("Enter number: ");
		int number = int.Parse(Console.ReadLine());

		string lastDigitAsWord = GetLastDigitAsWord(number);
		Console.WriteLine("\nLast digit as word: {0}", lastDigitAsWord);
	}

	private static string GetLastDigitAsWord(int number)
	{
		string[] digitsAsWords = { "zero", "one", "two", "three", "tour", "five", "six", "seven", "eight", "nine" };

		byte lastDigit = (byte)Math.Abs((number % 10));

		return digitsAsWords[lastDigit];
	}
}
