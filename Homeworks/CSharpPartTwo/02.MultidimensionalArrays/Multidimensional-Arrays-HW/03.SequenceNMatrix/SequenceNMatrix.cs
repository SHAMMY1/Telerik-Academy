//Problem 3. Sequence n matrix

//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour
//elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.
//Example:

//matrix			
//ha	fifi   ho	hi
//fo	ha	   hi	xx
//xxx	ho	   ha	xx
//result
//ha, ha, ha	

//matrix	
//s	   qq	s
//pp   pp	s
//pp   qq	s
//result
//s, s, s

using System;

class SequenceNMatrix
{
	static void Main()
	{
		string task = "Problem 3. Sequence n matrix\n\nWe are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour\nelements located on the same line, column or diagonal.\nWrite a program that finds the longest sequence of equal strings in the matrix.\nExample:\nmatrix			\nha	fifi     ho	hi\nfo	ha	 hi	xx\nxxx	ho	 ha	xx\nresult\nha, ha, ha	\n\nmatrix\ns	qq	s\npp	pp	s\npp	qq	s\nresult\ns, s, s\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		string[,] matrix = default(string[,]);

		//Uncomment one for testing
		//matrix = new string[,] { { "s", "qq", "s"}, { "pp", "pp", "s"}, { "pp", "qq", "s",} };
		//matrix = new string[,] { { "ha", "fifi", "ho", "hi" }, { "fo", "ha", "hi", "xx" }, { "xxx", "ho", "ha", "xx" } };


		//If tests are comment out read matrix from console
		if (matrix == null)
		{
			Console.Write("Enter N: ");
			int numberN = int.Parse(Console.ReadLine());

			Console.Write("Enter M: ");
			int numberM = int.Parse(Console.ReadLine());

			matrix = new string[numberN, numberM];

			ReadMatrixFromConsole(matrix);
		}

		int maxSize = 0;
		int[] maxIndex = { 0, 0 };

		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
			{
				int size = 1;
				int index = 1;

				while (i + index < matrix.GetLength(0) && matrix[i + index, j] == matrix[i, j])
				{
					size++;
					index++;
				}
				if (size > maxSize)
				{
					maxSize = size;
					maxIndex[0] = i;
					maxIndex[1] = j;
				}

				index = 1;

				while (j + index < matrix.GetLength(1) && matrix[i, j + index] == matrix[i, j])
				{
					size++;
					index++;
				}
				if (size > maxSize)
				{
					maxSize = size;
					maxIndex[0] = i;
					maxIndex[1] = j;
				}

				index = 1;

				while (i + index < matrix.GetLength(0) && j + index < matrix.GetLength(1) && matrix[i + index, j + index] == matrix[i, j])
				{
					size++;
					index++;
				}
				if (size > maxSize)
				{
					maxSize = size;
					maxIndex[0] = i;
					maxIndex[1] = j;
				}
			}
		}

		Console.WriteLine("matrix: ");

		PrintMatrix(matrix);

		Console.WriteLine("\nmax size: {0}  sequence: {1}", maxSize, MakeSequence(matrix[maxIndex[0], maxIndex[1]], maxSize));
	}

	static void ReadMatrixFromConsole(string[,] matrix)
	{
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			Console.WriteLine("Enter matrix row(ha,fifi,ho,hi)");
			string input = Console.ReadLine();

			string[] numbers = input.Split(new[] { ','}, StringSplitOptions.RemoveEmptyEntries);

			PushRow(matrix, numbers, i);
		}
	}

	static void PushRow(string[,] matrix, string[] strings, int row)
	{
		for (int i = 0; i < matrix.GetLength(1); i++)
		{
			matrix[row, i] = strings[i];
		}
	}

	static string MakeSequence(string word, int times)
	{
		string result = string.Empty;

		for (int i = 0; i < times; i++)
		{
			result += word + ", ";
		}

		return result.Trim(new[] { ' ', ',' });
	}

	static void PrintMatrix(string[,] matrix)
	{
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
			{
				Console.Write(matrix[i, j].PadRight(6));
			}
			Console.WriteLine();
		}
	}
}
