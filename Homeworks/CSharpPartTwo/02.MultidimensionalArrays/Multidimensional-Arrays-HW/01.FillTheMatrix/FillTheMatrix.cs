//Multidimensional Arrays
//Problem 1. Fill the matrix

//Write a program that fills and prints a matrix of size (n, n) as shown below:
//Example for n=4:

//a)			
//1	 5	9	13
//2	 6	10	14
//3	 7	11	15
//4	 8	12	16

//b)
//1	 8	9	16
//2	 7	10	15
//3	 6	11	14
//4	 5	12	13

//c)
//7	 11	14	16
//4	 8	12	15
//2	 5	9	13
//1	 3	6	10

//d)*
//1	 12	11	10
//2	 13	16	9
//3	 14	15	8
//4	 5	6	7

using System;

class FillTheMatrix
{
	static void Main()
	{
		string task = "Multidimensional Arrays\n\nProblem 1. Fill the matrix\nWrite a program that fills and prints a matrix of size (n, n) as shown below:\nExample for n=4:\n\na)\n1	5	9	13\n2	6	10	14\n3	7	11	15\n4	8	12	16\n\nb)\n1	8	9	16\n2	7	10	15\n3	6	11	14\n4	5	12	13\n\nc)\n7	11	14	16\n4	8	12	15\n2	5	9	13\n1	3	6	10\n\nd)*\n1	12	11	10\n2	13	16	9\n3	14	15	8\n4	5	6	7\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);
	}
}
