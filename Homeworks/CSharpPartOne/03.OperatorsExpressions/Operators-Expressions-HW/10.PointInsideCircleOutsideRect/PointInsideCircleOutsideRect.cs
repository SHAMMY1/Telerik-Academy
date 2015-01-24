//Problem 10. Point Inside a Circle & Outside of a Rectangle

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of
//the rectangle R(top=1, left=-1, width=6, height=2).
//Examples:

//x	    y	inside K & outside of R
//1	    2	       yes
//2.5	2	       no
//0	    1	       no
//2.5	1	       no
//2	    0	       no
//4	    0	       no
//2.5	1.5	       no
//2	    1.5	       yes
//1	    2.5	       yes
//-100  -100       no

using System;

class PointInsideCircleOutsideRect
{
	static void Main()
	{
		string task = "Problem 10. Point Inside a Circle & Outside of a Rectangle\n\nWrite an expression that checks for given point (x, y)\nif it is within the circle K({1, 1}, 1.5) and\nout of the rectangle R(top=1, left=-1, width=6, height=2).\nExamples:\nx	y	inside K & outside of R\n1	2	yes\n2.5	2	no\n0	1	no\n2.5	1	no\n2	0	no\n4	0	no\n2.5	1.5	no\n2	1.5	yes\n1	2.5	yes\n-100	-100	no\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter x:");
		double pointX = double.Parse(Console.ReadLine());

		Console.WriteLine("Enter y:");
		double pointY = double.Parse(Console.ReadLine());

		double circleX = 1;
		double circleY = 1;
		double circleRadius = 1.5;

		double rectTop = 1;
		double rectLeft = -1;
		double rectWidth = 6;
		double rectHeight = 2;
		double rectBottom = rectTop - rectHeight;
		double rectRight = rectLeft + rectWidth;

		double distanceToCircle = Math.Sqrt(Math.Pow(Math.Abs(pointX - circleX),2) + Math.Pow(Math.Abs(pointY - circleY),2));
		
		bool isInCircle = circleRadius >= distanceToCircle;

		bool isOutRectangle = (pointX < rectLeft) || (pointX > rectRight) || (pointY < rectBottom) || (pointY > rectTop);

		Console.WriteLine("Is point ({0}, {1}) within the circle K((1, 1), 1.5) and\nout of the rectangle R(top=1, left=-1, width=6, height=2): {2}", pointX, pointY, isInCircle && isOutRectangle);


	}
}
