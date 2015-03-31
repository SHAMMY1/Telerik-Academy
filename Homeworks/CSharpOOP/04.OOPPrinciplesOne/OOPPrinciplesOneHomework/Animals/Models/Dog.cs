using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
	public class Dog : Animal
	{
		public Dog(string name, double age, Sex sex)
			: base(name, age, sex) { }

		public override string Sound()
		{
			return "woof";
		}
	}
}
