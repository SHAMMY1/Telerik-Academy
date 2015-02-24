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
using System.Linq;

class LargestAreaInMatrix
{
	static void Main()
	{
		string task = "Problem 7.* Largest area in matrix\n\nWrite a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.\nExample:\n\nmatrix	\n1	3	2	2	2	4\n3	3	3	2	4	4\n4	3	1	2	3	3\n4	3	1	3	3	1\n4	3	3	3	1	1\n\nresult\n13\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		int[,] matrix = default(int[,]);

		matrix = new[,] { { 1, 3, 2, 2, 2, 4 }, { 3, 3, 3, 2, 4, 4 }, { 4, 3, 1, 2, 3, 3 }, { 4, 3, 1, 3, 3, 1 }, { 4, 3, 3, 3, 1, 1 } };

		if (matrix == null)
		{
			Console.Write("Enter N(N >= 3): ");
			int numberN = int.Parse(Console.ReadLine());

			Console.Write("Enter M(M >= 3): ");
			int numberM = int.Parse(Console.ReadLine());

			matrix = new int[numberN, numberM];

			ReadMatrixFromConsole(matrix);
		}

		bool[,] discovered = new bool[matrix.GetLength(0), matrix.GetLength(1)];
		int number = 0;
		int count = 0;
		int maxCount = 0;
		int[] maxPosition = { 0, 0 };

		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
			{
				if (!discovered[i, j])
				{
					count = DepthFirstSearch(matrix, discovered, i, j);

					if (maxCount < count)
					{
						maxCount = count;
						number = matrix[i, j];
						maxPosition[0] = i;
						maxPosition[1] = j;
					}
				}
			}
		}

		discovered = new bool[discovered.GetLength(0), discovered.GetLength(1)];

		Console.WriteLine("Matrix: ");

		printMatrix(matrix);

		DepthFirstSearch(matrix, discovered, maxPosition[0], maxPosition[1]);

		Console.WriteLine("Size: {0}", maxCount);

		Console.WriteLine("Area: ");

		printArea(discovered, matrix[maxPosition[0], maxPosition[1]]);
	}

	static void ReadMatrixFromConsole(int[,] matrix)
	{
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			Console.WriteLine("Enter matrix row(1, 2, 3 , 4)");
			string input = Console.ReadLine();

			int[] numbers = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();

			PushRow(matrix, numbers, i);
		}
	}

	static void PushRow(int[,] matrix, int[] numbers, int row)
	{
		for (int i = 0; i < matrix.GetLength(1); i++)
		{
			matrix[row, i] = numbers[i];
		}
	}

	private static int DepthFirstSearch(int[,] matrix, bool[,] discovered, int row, int col)
	{

		discovered[row, col] = true;
		int result = 1;

		if (row + 1 < matrix.GetLength(0) && matrix[row + 1, col] == matrix[row, col] && discovered[row + 1, col] == false )
		{
			result += DepthFirstSearch(matrix, discovered, row + 1, col);
		}

		if (row - 1 >= 0 && matrix[row - 1, col] == matrix[row, col] && discovered[row - 1, col] == false)
		{
			result += DepthFirstSearch(matrix, discovered, row - 1, col);
		}
		if (col + 1 < matrix.GetLength(1) && matrix[row, col + 1] == matrix[row, col] && discovered[row, col + 1] == false)
		{
			result += DepthFirstSearch(matrix, discovered, row, col + 1);
		}
		if (col - 1 >= 0 && matrix[row, col - 1] == matrix[row, col] && discovered[row, col - 1] == false)
		{
			result += DepthFirstSearch(matrix, discovered, row, col - 1);
		}

		return result;
	}

	private static void printArea(bool[,] matrix, int number)
	{
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
			{
				Console.Write(matrix[i,j] ? number.ToString().PadRight(8) : string.Empty.PadRight(8));
			}
			Console.WriteLine();
		}
		Console.WriteLine();
	}

	private static void printMatrix(int[,] matrix)
	{
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
			{
				Console.Write(matrix[i, j].ToString().PadRight(8));
			}
			Console.WriteLine();
		}
		Console.WriteLine();
	}
}
