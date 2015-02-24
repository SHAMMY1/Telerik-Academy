//Problem 7. One system to any other

//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).

using System;
using System.Text;

class OneSystemToAny
{
	static void Main()
	{
		string task = "Problem 7. One system to any other\n\nWrite a program to convert from any numeral system of given base s to any\nother numeral system of base d (2 ≤ s, d ≤ 16).\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.Write("Enter base to convert from: ");
		uint fromBase = uint.Parse(Console.ReadLine());

		Console.Write("Enter base to convert to: ");
		uint toBase = uint.Parse(Console.ReadLine());

		Console.WriteLine("Enter positive number: ");
		string number = Console.ReadLine();

		Console.WriteLine("\nNumber in {0} base: {1}",toBase, ConvertAnyToAny(number,fromBase,toBase));
	}

	private static string ConvertAnyToAny(string number, uint fromBase, uint toBase)
	{
		return DecimalToAny(AnyToDecimal(number, fromBase), toBase);
	}

	private static ulong AnyToDecimal(string number, uint baseSystem)
	{
		ulong result = 0;

		for (int i = number.Length - 1; i >= 0; i--)
		{
			uint CurrentNumber = (uint)(char.IsDigit(number[i]) ? number[i] - '0': number[i] - 'A' + 10);
			int pow = number.Length - i - 1;
			result += CurrentNumber * (ulong)Math.Pow(baseSystem, pow);
		}

		return result;
	}

	private static string DecimalToAny(ulong number, uint baseSystem)
	{
		StringBuilder result = new StringBuilder();

		do
		{
			int numberToAdd = (int)(number % baseSystem);
			result.Insert(0, (char)(numberToAdd <= 9 ? numberToAdd + '0': 'A' + numberToAdd - 10));
			number /= baseSystem;
		} while (number > 0);

		return result.ToString();
	}
}
