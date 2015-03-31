using SchoolSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Models
{
	public class SchoolClass : IClass
	{
		private ICollection<ITeacher> teachers;
		private ICollection<IStudent> students;

		public ICollection<ITeacher> Teachers
		{
			get 
			{ 
				return this.teachers; 
			}
			private set
			{
				this.teachers = value;
			}
		}

		public ICollection<IStudent> Students
		{
			get 
			{ 
				return this.students; 
			}
			private set
			{
				this.students = value;
			}
		}

		public SchoolClass()
		{
			this.Teachers = new List<ITeacher>();
			this.Students = new List<IStudent>();
		}

		public void AddStudent(IStudent student)
		{
			this.students.Add(student);
		}

		public void RemoveStudent(IStudent student)
		{
			this.students.Remove(student);
		}

		public void AddTeacher(ITeacher teacher)
		{
			this.teachers.Add(teacher);
		}

		public void RemoveTeacher(ITeacher teacher)
		{
			this.teachers.Remove(teacher);
		}

		public override string ToString()
		{
			StringBuilder result = new StringBuilder();

			result.Append("Teachers:\n");
			result.Append(string.Join(", ", this.teachers));
			result.Append("\nStudents:\n");
			result.Append(string.Join(", ", this.students));
			return result.ToString();
		}
	}
}
