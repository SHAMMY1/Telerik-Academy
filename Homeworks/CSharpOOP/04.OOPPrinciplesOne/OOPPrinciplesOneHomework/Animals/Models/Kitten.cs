using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
	public class Kitten : Cat
	{
		private const Sex kittenSex = Sex.Female;

		public Kitten(string name, double age)
			: base(name, age, kittenSex) { }
	}
}
