//Problem 20.* Variations of set

//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
//Example:

//N	 K	result
//3	 2	{1, 1} 
//		{1, 2} 
//		{1, 3} 
//		{2, 1} 
//		{2, 2} 
//		{2, 3} 
//		{3, 1} 
//		{3, 2} 
//		{3, 3}

using System;

class VariationsOfSet
{
	static int numN;
	static int numK;
	static int[] combo;

	static void Main()
	{
		string task = "Problem 20.* Variations of set\n\nWrite a program that reads two numbers N and K and generates all the variations\nof K elements from the set [1..N].\nExample:\nN	K	result\n3	2	{1, 1} \n   		{1, 2}\n            {1, 3} \n            {2, 1} \n            {2, 2} \n            {2, 3} \n            {3, 1} \n            {3, 2} \n            {3, 3}\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter number N:");
		numN = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter number K:");
		numK = int.Parse(Console.ReadLine());

		combo = new int[numK];

		GenerateCombo(0);
	}

	static void GenerateCombo(int startIndex)
	{
		if (startIndex >= numK)
		{
			Print(combo);
			return;
		}
		for (int i = 0; i < numN; i++)
		{
			combo[startIndex] = i + 1;
			GenerateCombo(startIndex + 1);
		}
	}

	static void Print(int[] array)
	{
		for (int i = 0; i < array.Length; i++)
		{
			Console.Write("{0} ", array[i]);
		}
		Console.WriteLine();
	}
}
