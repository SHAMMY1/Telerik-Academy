//Problem 15.* Age after 10 Years

//Write a program to read your birthday from the console and print how old you are now 
//and how old you will be after 10 years.
using System;

class AgeAfterTenYears
{
	static void Main()
	{
		string inputMessage = "Please input your birthday(day/month/year):";

		Console.WriteLine(inputMessage);

		string inputString = Console.ReadLine();

		var separators = new char[]{'.','/','\\',',',' '};

		var birthdayData = inputString.Split(separators, StringSplitOptions.RemoveEmptyEntries);

		try
		{
			int day = int.Parse(birthdayData[0]);
			int month = int.Parse(birthdayData[1]);
			int year = int.Parse(birthdayData[2]);


			DateTime birthdayDate = new DateTime(year, month, day);

			DateTime currentDate = DateTime.Now;

			bool isBirthdayPast = true;

			if (currentDate.Month < birthdayDate.Month)
			{
				isBirthdayPast = false;
			}
			else if (currentDate.Month == birthdayDate.Month)
			{
				if (currentDate.Day < birthdayDate.Day)
				{
					isBirthdayPast = false;
				}
			}

			int oldNow = currentDate.Year - birthdayDate.Year;

			oldNow = isBirthdayPast ? oldNow : oldNow - 1;

			int oldInTenYears = oldNow + 10;

			bool isBirthdayToday = currentDate.Month == birthdayDate.Month && currentDate.Day == birthdayDate.Day;

			string messageToPrint = string.Format("Now you are {0} years old, in ten years you will be {1} years old", oldNow, oldInTenYears);

			if (isBirthdayToday)
			{
				Console.WriteLine("Happy birthday!!!");
			}

			Console.WriteLine(messageToPrint);
		}

		catch (Exception)
		{
			Console.WriteLine("Invalid inpu data!!!");
			Main();
		}
	}
}
