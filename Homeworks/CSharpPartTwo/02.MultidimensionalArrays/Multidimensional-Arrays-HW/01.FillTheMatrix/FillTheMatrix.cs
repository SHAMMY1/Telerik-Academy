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

		Console.Write("Enter matrix size: ");
		int size = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter matrix variant(A,B,C,D)");
		char variant = char.Parse(Console.ReadLine().ToUpper());

		int padding = 8;

		switch (variant)
		{
			case 'A':
				Console.WriteLine("size: {0}X{0}  variant: {1})\n", size, variant);
				PrintMatrix(GetMatrixA(size, size), padding);
				break;
			case 'B':
				Console.WriteLine("size: {0}X{0}  variant: {1})\n", size, variant);
				PrintMatrix(GetMatrixB(size, size), padding);
				break;
			case 'C':
				Console.WriteLine("size: {0}X{0}  variant: {1})\n", size, variant);
				PrintMatrix(GetMatrixC(size, size), padding);
				break;
			case 'D':
				Console.WriteLine("size: {0}X{0}  variant: {1})\n", size, variant);
				PrintMatrix(GetMatrixD(size, size), padding);
				break;
			default:
				Console.WriteLine("Wrong variant");
				break;
		}
	}

	static int[,] GetMatrixA(int height,int width)
	{
		int[,] matrix = new int[height, width];

		for (int col = 0; col < matrix.GetLength(1); col++)
		{
			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				matrix[row, col] = (row + 1) + (col * matrix.GetLength(0));
			}
		}

		return matrix;
	}

	static int[,] GetMatrixB(int height, int width)
	{
		int[,] matrix = new int[height, width];

		for (int col = 0; col < matrix.GetLength(1); col++)
		{
			if (col %  2 == 0)
			{
				for (int row = 0; row < matrix.GetLength(0); row++)
				{
					matrix[row, col] = (row + 1) + (col * matrix.GetLength(0));
				}
			}
			else
			{
				for (int row = 0; row < matrix.GetLength(0); row++)
				{
					matrix[matrix.GetLength(0) - row - 1, col] = (row + 1) + (col * matrix.GetLength(0));
				}
			}
		}

		return matrix;
	}

	static int[,] GetMatrixC(int height, int width)
	{
		int[,] matrix = new int[height, width];

		int number = 1;

		int[] position = new int[2];

		for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
		{
			position[0] = i;
			position[1] = 0;

			do
			{
				matrix[position[0], position[1]] = number;
				number++;
				position[0]++;
				position[1]++;
			} while (position[0] < matrix.GetLength(0));
			
		}

		for (int i = 1; i < matrix.GetLength(1); i++)
		{
			position[1] = i;
			position[0] = 0;

			do
			{
				matrix[position[0], position[1]] = number;
				number++;
				position[0]++;
				position[1]++;
			} while (position[1] < matrix.GetLength(1));
		}

		return matrix;
	}

	static int[,] GetMatrixD(int height, int width)
	{
		int[,] matrix = new int[height, width];

		int[] directions = { 1, 0 };

		int[] pozition = { 0, 0 };
		for (int i = 1; i <= matrix.GetLength(0) * matrix.GetLength(1); i++)
		{
			matrix[pozition[0], pozition[1]] = i;

			if (pozition[0] + directions[0] >= matrix.GetLength(0)||pozition[1] +directions[1] >= matrix.GetLength(1) ||pozition[0] + directions[0] < 0||pozition[1] + directions[1] <0 ||matrix[pozition[0] + directions[0], pozition[1] + directions[1]] != 0)
			{
				if (directions[0] == 0)
				{
					if (directions[1] > 0)
					{
						directions[0]--;
						directions[1]--;
					}
					else
					{
						directions[0]++;
						directions[1]++;
					}
				}
				else
				{
					if (directions[0] > 0)
					{
						directions[1]++;
						directions[0]--;
					}
					else
					{
						directions[1]--;
						directions[0]++;
					}
				}
			}

			pozition[0] += directions[0];
			pozition[1] += directions[1];
		}

		return matrix;
	}

	static void PrintMatrix(int[,] matrix,int padding)
	{
		for (int row = 0; row < matrix.GetLength(0); row++)
		{
			for (int col = 0; col < matrix.GetLength(1); col++)
			{
				Console.Write("{0}", matrix[row,col].ToString().PadRight(padding));
			}

			Console.WriteLine();
		}
	}
}
