using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
	public class Tomcat : Cat
	{
		private const Sex tomcatSex = Sex.Male;

		public Tomcat(string name, double age)
			: base(name, age, tomcatSex) { }
	}
}
