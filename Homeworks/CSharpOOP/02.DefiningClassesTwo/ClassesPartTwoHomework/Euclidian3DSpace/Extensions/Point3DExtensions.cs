namespace Euclidian3DSpace.Extensions
{
	using Euclidian3DSpace.Models;
	using System;
	using System.Linq;

	public static class Point3DExtensions
	{
		public static double CalculateDistance(Point3D first, Point3D second)
		{
			double distance = 0.0;

			distance = Math.Sqrt(
				(first.X - second.X) * (first.X - second.X) +
				(first.X - second.Y) * (first.X - second.Y) +
				(first.X - second.Z) * (first.X - second.Z)
				);

			return distance;
		}

		public static double CalculateDistance(Point3D first)
		{
			return CalculateDistance(first, Point3D.PointO);
		}
	}
}
