//Problem 7. Encode/decode

//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with
//the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.

using System;

class EncodeDecode
{
	static void Main()
	{
		string task = "Problem 7. Encode/decode\n\nWrite a program that encodes and decodes a string using given encryption key\n(cipher).The key consists of a sequence of characters.\nThe encoding/decoding is done by performing XOR (exclusive or) operation over\nthe first letter of the string with the first of the key, the second – with the\nsecond, etc. When the last key character is reached, the next is the first.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
