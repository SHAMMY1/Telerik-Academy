using SchoolSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Models
{
	public class Comment : IComment
	{
		private IPerson author;
		private string content;
		public IPerson Author
		{
			get
			{
				return this.author;
			}
			set
			{
				this.author = value;
			}
		}

		public string Content
		{
			get
			{
				return this.content;
			}
			set
			{
				this.content = value;
			}
		}

		public Comment(IPerson author, string content)
		{
			this.Author = author;
			this.Content = content;
		}

		public override string ToString()
		{
			return string.Format("{0}\n{1}",this.Author.Name, this.Content);
		}
	}
}
