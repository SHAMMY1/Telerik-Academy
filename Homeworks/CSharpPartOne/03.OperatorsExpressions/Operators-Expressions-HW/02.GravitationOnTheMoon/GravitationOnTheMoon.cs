//Problem 2. Gravitation on the Moon

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
//Examples:

//weight	weight on the Moon
//86	    14.62
//74.6	12.682
//53.7	9.129

using System;
class GravitationOnTheMoon
{
	static void Main()
	{
		string task = "Problem 2. Gravitation on the Moon\n\nThe gravitational field of the Moon is approximately 17% of that on the Earth.\nWrite a program that calculates the weight of a man on the moon by a given\nweight on the Earth.\nExamples:\nweight	weight on the Moon\n86	14.62\n74.6	12.682\n53.7	9.129\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter earth weight:");
		double earthWeight = double.Parse(Console.ReadLine());

		double moonWeight = earthWeight * 17 / 100;

		Console.WriteLine();
		Console.WriteLine("Earth weight: {0}", earthWeight);
		Console.WriteLine("Moon weight: {0}", moonWeight);
	}
}
