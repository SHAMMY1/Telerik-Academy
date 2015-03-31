using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euclidian3DSpace.Models
{
	public struct Point3D
	{
		private static readonly Point3D pointO = new Point3D(0, 0, 0);

		public double X { get; set; }

		public double Y { get; set; }

		public double Z { get; set; }

		public static Point3D PointO
		{
			get 
			{ 
				return pointO; 
			}

		}

		public Point3D(double x, double y, double z)
			:this()
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
		}

		public static Point3D Parse(string input)
		{
			var coordinates = input.Split(new[] { ',', '(', ')' }, StringSplitOptions.RemoveEmptyEntries).Select(s => double.Parse(s)).ToArray();

			return new Point3D(coordinates[0], coordinates[1], coordinates[2]);
		}

		public override string ToString()
		{
			return string.Format("({0}, {1}, {2})", this.X, this.Y, this.Z);
		}
	}
}
