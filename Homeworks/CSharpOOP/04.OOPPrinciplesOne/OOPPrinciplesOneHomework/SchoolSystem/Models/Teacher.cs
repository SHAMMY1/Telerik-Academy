using SchoolSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Models
{
	public class Teacher : Person, ITeacher
	{
		private ICollection<IDiscipline> disciplines;

		public ICollection<IDiscipline> Disciplines
		{
			get 
			{
				return this.disciplines; 
			}

			private set 
			{
				this.disciplines = value;
			}
		}

		public Teacher(string name)
			:base(name)
		{
			this.Disciplines = new List<IDiscipline>();
		}

		public void AddDiscipline(IDiscipline discipline)
		{
			this.disciplines.Add(discipline);
		}

		public void RemoveDiscipline(IDiscipline discipline)
		{
			this.disciplines.Remove(discipline);
		}

		public override string ToString()
		{
			return string.Format("{0},{1}",base.ToString(),"Teacher");
		}
	}
}
