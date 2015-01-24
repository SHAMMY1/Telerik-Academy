//Problem 7. Point in a Circle

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
//Examples:

//x	     y	  inside
//0	     1	   true
//-2	 0	   true
//-1	 2	   false
//1.5	-1	   true
//-1.5  -1.5   false
//100	-30	   false
//0	     0	   true
//0.2	-0.8   true
//0.9	-1.93  false
//1	     1.655 true

using System;

class PointInACircle
{
	static void Main()
	{
		string task = "Problem 7. Point in a Circle\n\nWrite an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).\nExamples:\nx	y	inside\n0	1	true\n-2	0	true\n-1	2	false\n1.5	-1	true\n-1.5	-1.5	false\n100	-30	false\n0	0	true\n0.2	-0.8	true\n0.9	-1.93	false\n1	1.655	true\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter x:");
		double x = double.Parse(Console.ReadLine());

		Console.WriteLine("Enter y:");
		double y = double.Parse(Console.ReadLine());

		double circleDiameter = 2;

		bool isPointInCircle = false;

		if (Math.Sqrt((Math.Pow(Math.Abs(x), 2) + Math.Pow(Math.Abs(y), 2))) <= circleDiameter) 
		{
			isPointInCircle = true;
		}

		Console.WriteLine();
		Console.WriteLine("Is point({0}, {1}) in circle(0, 0, 2): {2}", x, y, isPointInCircle);
	}
}
