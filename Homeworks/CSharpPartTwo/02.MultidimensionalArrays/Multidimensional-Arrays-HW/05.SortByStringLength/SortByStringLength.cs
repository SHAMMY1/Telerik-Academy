//Problem 5. Sort by string length

//You are given an array of strings. Write a method that sorts the array by the length of its elements
//(the number of characters composing them).

using System;
using System.Linq;

class SortByStringLength
{
	static void Main()
	{
		string task = "Problem 5. Sort by string length\n\nYou are given an array of strings. Write a method that sorts the\narray by the length of its elements (the number of characters composing them).\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		string[] array = null;

		//Uncomment for testing
		//array = new[] { "aaaaaaaaaaaaa", "aaaaaaaaa", "aa", "aaaaaaaaaaaaaaaaaa", "a", "aaaaaaaaaaaaaaaaaaaaa", "aaaaa", "aaa" };

		if (array == null)
		{
			Console.WriteLine("enter string array separate by ','(aaaaaaaa,aaaaa,aaaa,aa,aaaaaaa): ");
			array = Console.ReadLine().Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);
		}

		Console.WriteLine("Array:\n{0}\n", string.Join("\n", array));

		Array.Sort<string>(array, (s1, s2) => s1.Length.CompareTo(s2.Length));

		Console.WriteLine("Sorted array:\n{0}", string.Join("\n", array));

	}
}
