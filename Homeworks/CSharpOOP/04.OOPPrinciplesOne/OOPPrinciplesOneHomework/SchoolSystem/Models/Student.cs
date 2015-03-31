using SchoolSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Models
{
	public class Student : Person, IStudent
	{
		public uint ClassNumber { get; set; }

		public Student(string name, uint number)
			: base(name)
		{
			this.ClassNumber = number;
		}

		public override string ToString()
		{
			return string.Format("{0},{1}", base.ToString(), "Student");
		}
	}
}
