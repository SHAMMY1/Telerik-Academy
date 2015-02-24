//Problem 12. Parse URL

//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
//Example:

//URL	                                                    Information
//http://telerikacademy.com/Courses/Courses/Details/212	    [protocol] = http 
//														    [server] = telerikacademy.com 
//														    [resource] = /Courses/Courses/Details/212

using System;

class ParseURL
{
	static void Main()
	{
		string task = "Problem 12. Parse URL\n\nWrite a program that parses an URL address given in the format:\n[protocol]://[server]/[resource] and extracts from it the [protocol],\n[server] and [resource] elements.\nExample:\nURL	                                                    \nhttp://telerikacademy.com/Courses/Courses/Details/212\nInformation\n[protocol] = http \n[server] = telerikacademy.com \n[resource] = /Courses/Courses/Details/212\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
