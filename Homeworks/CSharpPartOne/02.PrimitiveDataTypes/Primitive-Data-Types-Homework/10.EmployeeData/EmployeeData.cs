//Problem 10. Employee Data

//A marketing company wants to keep record of its employees.
//Each record would have the following characteristics:

//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee 
//using appropriate primitive data types. Use descriptive names. Print the data at the console.

using System;

class EmployeeData
{
	static void Main()
	{
		string task = "Problem 10. Employee Data\n\nA marketing company wants to keep record of its employees. Each record would have the following characteristics:\n\nFirst name\nLast name\nAge (0...100)\nGender (m or f)\nPersonal ID number (e.g. 8306112507)\nUnique employee number (27560000…27569999)\n\nDeclare the variables needed to keep the information for a single employee\nusing appropriate primitive data types.\nUse descriptive names. Print the data at the console.\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		string firstName = "Pesho";
		string lastName = "Goshov";
		byte age = 25;
		bool isMale = true;
		ulong id = 8306112507;
		uint uniqueEmployeeNumber = 27565555;

		Console.WriteLine("Name: {0}", firstName + " " + lastName);
		Console.WriteLine("Age: {0}", age);
		Console.WriteLine("Gender: {0}", isMale ? "Male" : "Female");
		Console.WriteLine("Personal ID number: {0}", id);
		Console.WriteLine("Unique employee number: {0}", uniqueEmployeeNumber);
	}
}
