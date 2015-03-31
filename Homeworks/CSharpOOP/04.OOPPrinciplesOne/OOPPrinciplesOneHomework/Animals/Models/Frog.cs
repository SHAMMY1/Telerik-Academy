using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
	public class Frog : Animal
	{
		public Frog(string name, double age, Sex sex)
			: base(name, age, sex) { }

		public override string Sound()
		{
			return "croak";
		}
	}
}
