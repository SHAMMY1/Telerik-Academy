using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Interfaces
{
	public interface IStudent : IPerson
	{
		uint ClassNumber { get; set; }
	}
}
