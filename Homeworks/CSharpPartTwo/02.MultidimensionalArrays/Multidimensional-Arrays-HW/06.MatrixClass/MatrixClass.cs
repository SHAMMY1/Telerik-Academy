//Problem 6.* Matrix class

//Write a class Matrix, to hold a matrix of integers. Overload the operators for adding, subtracting and multiplying
//of matrices, indexer for accessing the matrix content and ToString().

using System;
using System.Text;

class MatrixClass
{
	static void Main(string[] args)
	{
		string task = "Problem 6.* Matrix class\n\nWrite a class Matrix, to hold a matrix of integers. Overload the operators for\nadding, subtracting and multiplying of matrices, indexer for accessing the\nmatrix content and ToString().\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Matrix first = new Matrix(5,5);
		Matrix second = new Matrix(5, 5);
		for (int i = 0; i < first.Height; i++)
		{

			int increase = i * first.Height;

			for (int j = 0; j < first.Width; j++)
			{
				first[i, j] = j + increase + 1;
			}
		}

		for (int i = 0; i < first.Height; i++)
		{

			int increase = i * first.Height;

			for (int j = 0; j < first.Width; j++)
			{
				second[i, j] = 2;
			}
		}

		Console.WriteLine("First matrix:\n{0}\n\nSecond matrix:\n{1}\n",first, second);

		Console.WriteLine("First + second:\n{0}",first + second);
		Console.WriteLine();
		Console.WriteLine("First - second:\n{0}", first - second);
		Console.WriteLine();
		Console.WriteLine("First * second:\n{0}", first * second);
	}
}

public class Matrix
{
	private int[,] matrix;
	private int height;
	private int width;

	public  Matrix(int height, int width)
	{
		this.Height = height;
		this.Width = width;
		this.matrix = new int[height, width];
	}

	public int Height 
	{ 
		get 
		{ 
			return this.matrix.GetLength(0);
		}

		set
		{
			if (value <= 0)
			{
				throw new ArgumentOutOfRangeException("Height must be greater than 0");
			}

			this.height = value;
		}
	}

	public int Width 
	{ 
		get
		{
			return this.matrix.GetLength(1); 
		}

		set
		{
			if (value <= 0)
			{
				throw new ArgumentOutOfRangeException("Width must be greater than 0");
			}

			this.width = value;
		}}

	public int this[int row, int col]
	{
		get 
		{
			return this.matrix[row, col];
		}
		set
		{
			if (row < 0 || row >= this.Height || col < 0 || col >= this.Width)
			{
				throw new ArgumentOutOfRangeException("Index","Index was outside of the bouds of the matrix");
			}

			this.matrix[row, col] = value;
		}
	}
	

	public static Matrix operator +(Matrix first, Matrix second)
	{
		if (first.Height != second.Height || first.Width != second.Width)
		{
			throw new ArgumentException("Width and height of the matrices must be equale");
		}

		Matrix result = new Matrix(first.Height, first.Width);

		for (int i = 0; i < result.Height; i++)
		{
			for (int j = 0; j < result.Width; j++)
			{
				result[i, j] = first[i, j] + second[i, j];
			}
		}

		return result;
	}

	public static Matrix operator -(Matrix first, Matrix second)
	{
		if (first.Height != second.Height || first.Width != second.Width)
		{
			throw new ArgumentException("Width and height of the matrices must be equale");
		}

		Matrix result = new Matrix(first.Height, first.Width);

		for (int i = 0; i < result.Height; i++)
		{
			for (int j = 0; j < result.Width; j++)
			{
				result[i, j] = first[i, j] - second[i, j];
			}
		}

		return result;
	}

	public static Matrix operator *(Matrix first, Matrix second)
	{
		if (first.Width != second.Height)
		{
			throw new ArgumentException("Invalid operation");
		}

		Matrix result = new Matrix(first.Height, second.Width);

		for (int row = 0; row < result.Height; row++)
		{
			for (int col = 0; col < result.Width; col++)
			{
				int number = 0;

				for (int i = 0; i < first.width; i++)
				{
					number += first[row, i] * second[i, col];
				}

				result[row, col] = number;
			}
		}

		return result;
	}

	public string  ToString(int padding = 6)
	{
		StringBuilder result = new StringBuilder();

		for (int row = 0; row < this.Height; row++)
		{
			for (int col = 0; col < this.Width; col++)
			{
				result.Append(this.matrix[row, col].ToString().PadRight(padding));
			}

			if (row < this.Height - 1)
			{
				result.AppendLine();				
			}
		}

		return result.ToString();
	}

	public override string ToString()
	{
		return this.ToString();
	}
}
