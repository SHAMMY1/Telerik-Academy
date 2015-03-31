using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Interfaces
{
	public interface IComment
	{
		IPerson Author { get; set; }

		string Content { get; set; }
	}
}
