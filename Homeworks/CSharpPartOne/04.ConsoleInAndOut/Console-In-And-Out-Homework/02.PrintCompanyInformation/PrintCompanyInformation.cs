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
//Address: 31 Al. Malinov, Sofia
//Tel. +359 888 55 55 555
//Fax: (no fax)
//Web site: http://telerikacademy.com/
//Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981)

using System;

class PrintCompanyInformation
{
	static void Main()
	{
		string task = "Problem 2. Print Company Information\n\nA company has name, address, phone number, fax number, web site and manager.\nThe manager has first name, last name, age and a phone number.\nWrite a program that reads the information about a company\nand its manager and prints it back on the console.\n\nExample input:\nprogram	                user\nCompany name:	        Telerik Academy\nCompany address:	31 Al. Malinov, Sofia\nPhone number:	        +359 888 55 55 555\nFax number:	\nWeb site:	        http://telerikacademy.com/\nManager first name:	Nikolay\nManager last name:	Kostov\nManager age:	        25\nManager phone:	        +359 2 981 981\n\nExample output:\nTelerik Academy\nAddress: 31 Al. Malinov, Sofia\nTel. +359 888 55 55 555\nFax: (no fax)\nWeb site: http://telerikacademy.com/\nManager: Nikolay Kostov (age: 25, tel. +359 2 981 981)\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.Write("Enter company name: ");
		string companyName = Console.ReadLine();


		Console.Write("Enter company adress: ");
		string companyAdress = Console.ReadLine();


		Console.Write("Enter company phone number: ");
		string companyPhoneNumber = Console.ReadLine();


		Console.Write("Enter company fax: ");
		string companyFax = Console.ReadLine();


		Console.Write("Enter company web site: ");
		string companyWebSite = Console.ReadLine();


		Console.Write("Enter company manager first name: ");
		string companyManagerFirstName = Console.ReadLine();

		Console.Write("Enter company manager last name: ");
		string companyManagerLastName = Console.ReadLine();

		Console.Write("Enter company manager age: ");
		string companyManagerAge = Console.ReadLine();

		Console.Write("Enter company manager phone: ");
		string companyManagerPhone = Console.ReadLine();

		string managerInfo = string.Format("{0} {1} (age: {2}, tel. {3})"
			                               , companyManagerFirstName
										   , companyManagerLastName
										   , companyManagerAge
										   , companyManagerPhone == string.Empty ? "(no phone)" : companyManagerPhone);

		string companyInfo = string.Format("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5}"
										   , companyName
										   , companyAdress == string.Empty ? "(no adress)" : companyAdress
										   , companyPhoneNumber == string.Empty ? "(no phone number)" : companyPhoneNumber
										   , companyFax == string.Empty ? "(no fax)" : companyFax
										   , companyWebSite == string.Empty ? "(no web side)" : companyWebSite
										   , managerInfo);


		Console.WriteLine();
		Console.WriteLine(companyInfo);
	}										
}											
											