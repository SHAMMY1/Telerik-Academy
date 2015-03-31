using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Interfaces
{
	public interface ICommentable
	{
		ICollection<IComment> Comments { get;}

		void AddComment(IComment comment);

		void RemoveComment(IComment comment);
	}
}
