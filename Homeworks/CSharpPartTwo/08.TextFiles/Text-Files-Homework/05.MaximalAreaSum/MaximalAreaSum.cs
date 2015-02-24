//Problem 5. Maximal area sum

//Write a program that reads a text file containing a square matrix of numbers.
//Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file.
//Example:

//input	  output
//4         17
//2 3 3 4 
//0 2 3 4 
//3 7 1 2 
//4 3 3 2	

using System;

class MaximalAreaSum
{
	static void Main()
	{
		string task = "Problem 5. Maximal area sum\n\nWrite a program that reads a text file containing a square matrix of numbers.\nFind an area of size 2 x 2 in the matrix, with a maximal sum of its elements.\nThe first line in the input file contains the size of matrix N.\nEach of the next N lines contain N numbers separated by space.\nThe output should be a single number in a separate text file.\nExample:\n\ninput	output\n4       17\n2 3 3 4 \n0 2 3 4 \n3 7 1 2 \n4 3 3 2	\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
