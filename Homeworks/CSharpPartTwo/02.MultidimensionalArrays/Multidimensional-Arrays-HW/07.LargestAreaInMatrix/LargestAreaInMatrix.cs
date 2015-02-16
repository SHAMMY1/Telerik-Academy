//Problem 7.* Largest area in matrix

//Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.
//Example:

//matrix	
//1	 3	2	2	2	4
//3	 3	3	2	4	4
//4	 3	1	2	3	3
//4	 3	1	3	3	1
//4	 3	3	3	1	1

//result
//13

using System;

class LargestAreaInMatrix
{
	static void Main()
	{
		string task = "Problem 7.* Largest area in matrix\n\nWrite a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.\nExample:\n\nmatrix	\n1	3	2	2	2	4\n3	3	3	2	4	4\n4	3	1	2	3	3\n4	3	1	3	3	1\n4	3	3	3	1	1\n\nresult\n13\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);
	}
}
