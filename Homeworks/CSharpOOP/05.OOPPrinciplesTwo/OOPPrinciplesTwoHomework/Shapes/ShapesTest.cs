namespace Shapes
{
	using System.Collections.Generic;
	using System.Linq;
	using Shapes.Models;


	public static class ShapesTest
	{
		public static void Main()
		{
			var Shapes = new List<Shape>()
			{
				new Rectangle(4.5, 2.3),
				new Triangle(2, 4.5),
				new Square(3.7),
				new Rectangle(3.5, 4.3),
				new Triangle(3.4, 5.5),
				new Square(4.7),
				new Rectangle(8.5, 5.3),
				new Triangle(1.6, 5.6),
				new Square(5.8),
				new Rectangle(6.7, 3.5),
				new Triangle(2.8, 9.2),
				new Square(4.4),
				new Rectangle(2.7, 5.3),
				new Triangle(2.9, 7.8),
				new Square(3.3)
			};

			System.Console.WriteLine("All shapes sorted by surface:");

			foreach (var shape in Shapes.OrderBy(s => s.CalculateSurface()))
			{
				System.Console.WriteLine("Type: {0,-10}  Height: {1,-3}  Width: {2,-3}  Surface: {3}", shape.GetType().Name, shape.Height, shape.Width, shape.CalculateSurface());
			}
		}
	}
}
