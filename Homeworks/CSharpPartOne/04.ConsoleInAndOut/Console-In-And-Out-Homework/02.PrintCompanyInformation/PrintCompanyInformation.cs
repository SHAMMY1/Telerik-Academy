//Problem 2. Print Company Information

//A company has name, address, phone number, fax number, web site and manager. The manager has first name, 
//last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.
//Example input:

//program	                 user
//Company name:	        Telerik Academy
//Company address:	    31 Al. Malinov, Sofia
//Phone number:	        +359 888 55 55 555
//Fax number:		    
//Web site:	            http://telerikacademy.com/
//Manager first name:	Nikolay
//Manager last name:	Kostov
//Manager age:	        25
//Manager phone:	    +359 2 981 981

//Example output:

//Telerik Academy
//Address: 231 Al. Malinov, Sofia
//Tel. +359 888 55 55 555
//Fax: (no fax)
//Web site: http://telerikacademy.com/
//Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981)

using System;

class PrintCompanyInformation
{
	static void Main()
	{
		string task = "Problem 2. Print Company Information\n\nA company has name, address, phone number, fax number, web site and manager.\nThe manager has first name, last name, age and a phone number.\nWrite a program that reads the information about a company\nand its manager and prints it back on the console.\n\nExample input:\nprogram	                user\nCompany name:	        Telerik Academy\nCompany address:	31 Al. Malinov, Sofia\nPhone number:	        +359 888 55 55 555\nFax number:	\nWeb site:	        http://telerikacademy.com/\nManager first name:	Nikolay\nManager last name:	Kostov\nManager age:	        25\nManager phone:	        +359 2 981 981\n\nExample output:\nTelerik Academy\nAddress: 231 Al. Malinov, Sofia\nTel. +359 888 55 55 555\nFax: (no fax)\nWeb site: http://telerikacademy.com/\nManager: Nikolay Kostov (age: 25, tel. +359 2 981 981)\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);
	}
}
