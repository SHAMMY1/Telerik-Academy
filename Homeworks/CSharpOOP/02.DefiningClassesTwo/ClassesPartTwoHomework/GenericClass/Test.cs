namespace GenericClass
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	using GenericClass.Models;

	class Test
	{
		static void Main()
		{
			var list = new GenericList<int>(5);

			for (int i = 0; i < 5; i++)
			{
				list.Add(i + 1);
			}
			list.Add(6);
			list.RemoveAt(2);
			list.AddAt(2, 10);
			list.AddAt(2, 10);
		}
	}
}
