using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Interfaces
{
	public interface ITeacher : IPerson
	{
		ICollection<IDiscipline> Disciplines { get;}

		void AddDiscipline(IDiscipline discipline);

		void RemoveDiscipline(IDiscipline discipline);
	}
}
