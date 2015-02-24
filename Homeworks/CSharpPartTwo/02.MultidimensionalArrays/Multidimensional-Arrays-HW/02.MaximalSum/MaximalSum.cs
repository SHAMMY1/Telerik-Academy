//Problem 2. Maximal sum

//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has
//maximal sum of its elements.

using System;
using System.Linq;

class MaximalSum
{
	static void Main()
	{
		string task = "Problem 2. Maximal sum\n\nWrite a program that reads a rectangular matrix of size N x M and finds in it\nthe square 3 x 3 that has maximal sum of its elements.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		int[,] matrix = default(int[,]);

		//Uncoment for testing
		//matrix = new[,] { { 1, 5, 3, 6, 8 }, { 2, 3, 1, 5, 6 }, { 100, 3, 7, 9, 1 }, { 1, 1, 1, 1, 1 } };


		//If test is comment out read matrix from console
		if (matrix == null)
		{
			Console.Write("Enter N(N >= 3): ");
			int numberN = int.Parse(Console.ReadLine());

			Console.Write("Enter M(M >= 3): ");
			int numberM = int.Parse(Console.ReadLine());

			matrix = new int[numberN, numberM];

			ReadMatrixFromConsole(matrix);
		}

		int subMatrixSize = 3;

		if (subMatrixSize > matrix.GetLength(0) || subMatrixSize > matrix.GetLength(1))
		{
			Console.WriteLine("Matrix width and height must be bigger than 3!!!");
		}
		else
		{
			long maxSum = long.MinValue;
			int maxRow = 0;
			int maxCol = 0;

			for (int row = 0; row < matrix.GetLength(0) - subMatrixSize + 1; row++)
			{
				for (int col = 0; col < matrix.GetLength(0) - subMatrixSize + 1; col++)
				{
					long currentSum = GetSubMatrixSum(matrix, subMatrixSize, row, col);

					if (currentSum > maxSum)
					{
						maxSum = currentSum;
						maxRow = row;
						maxCol = col;
					}
				}
			}

			Console.WriteLine("Matrix: ");

			PrintSubMatrix(matrix, matrix.GetLength(0), matrix.GetLength(1), 0, 0, 6);

			Console.WriteLine("\nmax sum: {0}\nsquare:\n", maxSum);

			PrintSubMatrix(matrix, subMatrixSize,subMatrixSize, maxRow, maxCol, 6);
		}

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

	static long GetSubMatrixSum(int[,] matrix, int size,int row, int col)
	{
		long sum = 0;

		for (int i = row; i < size; i++)
		{
			for (int j = col; j < size; j++)
			{
				sum += matrix[i, j];
			}
		}

		return sum;
	}

	static void PrintSubMatrix(int[,] matrix, int height, int width, int row, int col,int padding)
	{
		for (int i = row; i < height; i++)
		{
			for (int j = col; j < width; j++)
			{
				Console.Write(matrix[i,j].ToString().PadRight(padding));
			}
			Console.WriteLine();
		}
	}
}
