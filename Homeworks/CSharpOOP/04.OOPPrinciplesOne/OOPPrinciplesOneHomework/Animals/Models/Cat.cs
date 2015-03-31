using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
	public abstract class Cat : Animal
	{
		public override string Sound()
		{
			return "Miaw";
		}

		public Cat(string name, double age, Sex sex)
			: base(name, age, sex) { }
	}
}
