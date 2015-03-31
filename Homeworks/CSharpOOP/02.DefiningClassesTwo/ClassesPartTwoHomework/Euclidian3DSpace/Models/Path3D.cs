namespace Euclidian3DSpace.Models
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;

	public class Path3D : IEnumerable<Point3D>
	{
		private ICollection<Point3D> points;

		public void AddPoint(Point3D point)
		{
			this.points.Add(point);
		}

		public void RemovePoint(Point3D point)
		{
			this.points.Remove(point);
		}

		public Path3D()
		{
			this.points = new List<Point3D>();
		}

		public IEnumerator<Point3D> GetEnumerator()
		{
			return this.points.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

				public override string ToString()
		{
			return string.Join(", ", this.points.Select(p => p.ToString())); 
		}
	}
}
