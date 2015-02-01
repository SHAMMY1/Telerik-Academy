//Problem 2. Bonus Score

//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//If the score is between 1 and 3, the program multiplies it by 10.
//If the score is between 4 and 6, the program multiplies it by 100.
//If the score is between 7 and 9, the program multiplies it by 1000.
//If the score is 0 or more than 9, the program prints “invalid score”.
//Examples:

//score	  result
//2	      20
//4	      400
//9	      9000
//-1	  invalid score
//10	  invalid score

using System;

class BonusScore
{
	static void Main()
	{
		string task = "Problem 2. Bonus Score\n\nWrite a program that applies bonus score to given score in the range [1…9]\nby the following rules:\nIf the score is between 1 and 3, the program multiplies it by 10.\nIf the score is between 4 and 6, the program multiplies it by 100.\nIf the score is between 7 and 9, the program multiplies it by 1000.\nIf the score is 0 or more than 9, the program prints “invalid score”.\nExamples:\n\nscore	result\n2	20\n4	400\n9	9000\n-1	invalid score\n10	invalid score\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.Write("Enter score in the range [1…9]: ");
		int score = int.Parse(Console.ReadLine());

		if (1 <= score && score <= 9)
		{
			if (score >= 4)
			{
				if (score >= 7)
				{
					score *= 10;
				}

				score *= 10;
			}

			score *= 10;
			Console.WriteLine("Final score: {0}", score);
		}
		else
		{
			Console.WriteLine("invalid score");
		}
	}
}
