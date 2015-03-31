using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Interfaces
{
	public interface IDiscipline
	{
		string Name { get; set; }
		int Lectures { get; set; }
		int Exercises { get; set; }
	}
}
