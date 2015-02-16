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
	}
}
