using SchoolSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Models
{
	public class Discipline : IDiscipline
	{
		private string name;
		private int lectures;
		private int exercises;
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

		public int Lectures
		{
			get
			{
				return this.lectures;
			}
			set
			{
				this.lectures = value;
			}
		}

		public int Exercises
		{
			get
			{
				return this.exercises;
			}
			set
			{
				this.exercises = value;
			}
		}

		public Discipline(string name, int lectures, int exercises)
		{
			this.Name = name;
			this.Lectures = lectures;
			this.Exercises = exercises;
		}
	}
}
