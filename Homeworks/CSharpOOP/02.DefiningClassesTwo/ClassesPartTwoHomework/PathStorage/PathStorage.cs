namespace PathStorage
{
	using Euclidian3DSpace.Models;
	using System.IO;

	public static class PathStorage
	{
		public static void SavePath(Path3D path, string failPath)
		{
			using (var sw = new StreamWriter(failPath))
			{
				foreach (var point in path)
				{
					sw.WriteLine(point);
				}
			}
		}

		public static Path3D LoadPath(string failPath)
		{
			var path = new Path3D();

			using (var sr = new StreamReader(failPath))
			{
				string line;

				while ((line = sr.ReadLine()) != null)
				{
					var point = Point3D.Parse(line);
					path.AddPoint(point);
				}
			}

			return path;
		}


	}

}
