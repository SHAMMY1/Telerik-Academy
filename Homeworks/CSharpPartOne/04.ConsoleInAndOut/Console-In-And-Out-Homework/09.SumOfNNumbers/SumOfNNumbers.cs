//Problem 9. Sum of n Numbers

//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 
//Note: You may need to use a for-loop.
//Examples:

//numbers	sum
//3	        90
//20	
//60	
//10	

//5	        6.5
//2	
//-1	
//-0.5	
//4	
//2	

//1	        1
//1

using System;

class SumOfNNumbers
{
	static void Main()
	{
		string task = "Problem 9. Sum of n Numbers\n\nWrite a program that enters a number n and after that enters more n numbers and calculates and prints their sum.\nNote: You may need to use a for-loop.\nExamples:\nnumbers	sum\n3	90\n20	\n60	\n10	\n\n5	6.5\n2	\n-1	\n-0.5	\n4	\n2	\n\n1	1\n1\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);
	}
}
