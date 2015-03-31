using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers.Models
{
	public class Worker : Human
	{
		public double WorkSalary { get; set; }

		public double WorkHoursePerDay { get; set; }

		public Worker(string firstName, string lastName, double salary, double workHours)
			: base(firstName, lastName)
		{
			this.WorkSalary = salary;
			this.WorkHoursePerDay = workHours;
		}

		public double MoneyPerHour()
		{
			return (WorkSalary / 22) / this.WorkHoursePerDay;
		}
	}
}
