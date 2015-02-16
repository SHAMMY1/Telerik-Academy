//Problem 3. Min, Max, Sum and Average of N Numbers

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number,
//the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.
//Example 1:

//input	output
//3       min = 1 
//2       max = 5 
//5       sum = 8 
//1       avg = 2.67	
    
    
    
//Example 2:

//input	  output
//2       min = -1 
//-1 	  max = 4 
//4		  sum = 3 
//		  avg = 1.50
    
    

using System;

class MinMaxSumAndAverage
{
	static void Main()
	{
		string task = "Problem 3. Min, Max, Sum and Average of N Numbers\n\nWrite a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).\nThe input starts by the number n (alone in a line) followed by n lines, each holding an integer number.\nThe output is like in the examples below.\nExample 1:\ninput	output\n3    min = 1 \n2 	 max = 5 \n5 	 sum = 8 \n1	 avg = 2.67\nExample 2:\ninput	output\n2    min = -1 \n-1 	 max = 4 \n4	 sum = 3 \navg = 1.50\n";
    
    
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.Write("Enter number N: ");
		int numberN = int.Parse(Console.ReadLine());

		int[] numbers = new int[numberN];

		for (int i = 0; i < numbers.Length; i++)
		{
			Console.Write("enter number: ");
			numbers[i] = int.Parse(Console.ReadLine());
		}

		int min = numbers[0];
		int max = numbers[1];
		int sum = 0;

		for (int i = 0; i < numbers.Length; i++)
		{
			if (min > numbers[i])
			{
				min = numbers[i];
			}

			if (max < numbers[i])
			{
				max = numbers[i];
			}

			sum += numbers[i];
		}

		double average = (double)((double)sum / (double)numbers.Length);

		Console.WriteLine("Min: {0}\nMax: {1}\nSum: {2}\nAverage: {3:F2}", min, max, sum, average);
	}
}
