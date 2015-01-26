//Problem 12.** Falling Rocks

//Implement the "Falling Rocks" game in the text console.
//A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
//A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
//Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
//Ensure a constant game speed by Thread.Sleep(150).
//Implement collision detection and scoring system.

using System;

class FallingRocks
{
	static void Main()
	{
		string task = "Problem 12.** Falling Rocks\n\nImplement the \"Falling Rocks\" game in the text console.\nA small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).\nA number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.\nRocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).\nEnsure a constant game speed by Thread.Sleep(150).\nImplement collision detection and scoring system.\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);
		Console.WriteLine("Press any key to start the game . . .");
		Console.ReadKey();
	}
}
