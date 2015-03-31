using Euclidian3DSpace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathStorage
{
	class Test
	{
		public static void Main()
		{
			var path = new Path3D();

			for (int i = 1; i <= 5; i++)
			{
				path.AddPoint(new Point3D(i, i, i));
			}

			Console.WriteLine(path);

			PathStorage.SavePath(path, "../../path.txt");

			var newPath = PathStorage.LoadPath("../../path.txt");

			Console.WriteLine(path.ToString());
		}
	}
}
