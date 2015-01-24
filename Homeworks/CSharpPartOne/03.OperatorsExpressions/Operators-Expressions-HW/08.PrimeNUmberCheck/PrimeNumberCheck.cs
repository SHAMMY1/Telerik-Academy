//Problem 8. Prime Number Check

//Write an expression that checks if given positive integer number n (n <= 100) is prime 
//(i.e. it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive
//Examples:

//n	  Prime?
//1	  false
//2	  true
//3	  true
//4	  false
//9	  false
//97  true
//51  false
//-3  false
//0	  false

using System;

class PrimeNumberCheck
{
	static void Main()
	{
		string task = "Problem 8. Prime Number Check\n\nWrite an expression that checks if given positive integer number n (n <= 100)\nis prime (i.e. it is divisible without remainder only to itself and 1).\nNote: You should check if the number is positive\nExamples:\nn	Prime?\n1	false\n2	true\n3	true\n4	false\n9	false\n97	true\n51	false\n-3	false\n0	false\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter number");
		int number = int.Parse(Console.ReadLine());

		bool isPrime = true;

		if (number < 2)
		{
			isPrime = false;
		}
		else
		{
			int boundary = (int)Math.Floor(Math.Sqrt(number));

			for (int i = 2; i <= boundary; i++)
			{
				if (number % i == 0)
				{
					isPrime = false;
				}
			}
		}

		Console.WriteLine("Is {0} prime: {1}", number, isPrime);
	}
}
