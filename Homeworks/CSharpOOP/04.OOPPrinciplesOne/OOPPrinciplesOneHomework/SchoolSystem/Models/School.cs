using SchoolSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Models
{
	public class School : ISchool
	{
		private ICollection<IClass> classes;

		public string Name { get; set; }

		public ICollection<IClass> Classes
		{
			get 
			{ 
				return this.classes; 
			}

			private set
			{
				this.classes = value;
			}
		}

		public School(string name)
		{
			this.Name = name;
			this.Classes = new List<IClass>();
		}

		public void AddClass(IClass classToAdd)
		{
			this.classes.Add(classToAdd);
		}

		public void RemoveClass(IClass classToRemove)
		{
			this.classes.Remove(classToRemove);
		}

		public override string ToString()
		{
			StringBuilder result = new StringBuilder();

			result.Append(string.Format("Name: {0}\nClasses:\n{1}", this.Name, string.Join("",this.Classes)));
			return result.ToString();
		}
	}
}
