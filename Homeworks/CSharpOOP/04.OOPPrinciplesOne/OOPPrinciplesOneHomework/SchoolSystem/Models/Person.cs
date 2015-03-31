using SchoolSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Models
{
	public abstract class Person : IPerson 
	{
		private string name;

		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		public Person(string name)
		{
			this.Name = name;
		}

		public override string ToString()
		{
			return this.Name;
		}
	}
}
