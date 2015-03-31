using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Interfaces
{
	public interface IClass
	{
		ICollection<ITeacher> Teachers{ get;}
		ICollection<IStudent> Students{ get;}

		void AddStudent(IStudent student);

		void RemoveStudent(IStudent student);

		void AddTeacher(ITeacher teacher);

		void RemoveTeacher(ITeacher teacher);

	}
}
