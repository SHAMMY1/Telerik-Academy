using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
	public abstract class Animal : ISound
	{
		public double Age { get; set; }

		public string Name { get; set; }

		public Sex Sex{ get; set; }

		public Animal(string name, double age, Sex sex)
		{ 
			this.Name = name;
			this.Age = age;
			this.Sex = sex;
		}

		public abstract string Sound();

	}

	public enum Sex
	{ 
		Male,
		Female
	}
}
