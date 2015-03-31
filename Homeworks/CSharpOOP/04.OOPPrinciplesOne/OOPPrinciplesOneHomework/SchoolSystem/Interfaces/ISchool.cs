using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Interfaces
{
	public interface ISchool
	{
		ICollection<IClass> Classes { get;}

		void AddClass(IClass classToAdd);

		void RemoveClass(IClass classToRemove);
	}
}
