//Problem 5. Boolean Variable

//Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender.
//Print it on the console.

using System;

class BooleanVariable
{
	static void Main()
	{
		string task = "Problem 5. Boolean Variable\n\nDeclare a Boolean variable called isFemale and assign an appropriate \nvalue corresponding to your gender.Print it on the console.\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		bool isFemale = false;

		Console.WriteLine("I am a female: {0}", isFemale);
	}
}
