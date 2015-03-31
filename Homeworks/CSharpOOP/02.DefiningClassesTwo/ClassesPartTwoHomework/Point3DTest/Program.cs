namespace Point3DTest
{
	using Euclidian3DSpace.Extensions;
	using Euclidian3DSpace.Models;
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			Point3D point = new Point3D(1,1,1);

			Console.WriteLine(point.ToString());

			Console.WriteLine(Point3DExtensions.CalculateDistance(point).ToString("F2"));
			Console.WriteLine(Math.Sqrt(3).ToString("F2"));
		}
	}
}
