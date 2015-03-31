using StudentsAndWorkers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
	class Program
	{
		static void Main()
		{
			List<Student> students = new List<Student>()
			{
				new Student("Ivan", "Petrov", 5),
				new Student("Dimitar", "Vasev", 2),
				new Student("Petar", "Todorov", 3),
				new Student("Stafan", "Mihailov", 5),
				new Student("Dragan", "Dimitrov", 6),
				new Student("Georgi", "Ivanov", 6),
				new Student("Pencho", "Stoilov", 4),
				new Student("Strahil", "Neshev", 3),
				new Student("Todor", "Georgiev", 6),
				new Student("Mihail", "Ivanov", 5),
			};

			List<Worker> workers = new List<Worker>()
			{
				new Worker("Ivan","Ivanov",550,8),
				new Worker("Konstantin","Danailov",950,4),
				new Worker("Milko","Gospodinov",800,6),
				new Worker("Boris","Mavrodiev",500,4.5),
				new Worker("Kristian","Iankulov",1500,8.5),
				new Worker("Nikola","Ivanov",2000,2),
				new Worker("Vasil","Vasilev",450,4),
				new Worker("Angel","Mitev",200,6.5),
				new Worker("Stefan","Gerasimov",1000,6),
				new Worker("Ivan","Strahinov",800,8),
			};

			Console.WriteLine("Students:");
			foreach (var student in students)
			{
				Console.WriteLine("{0,-10} {1,-10} Grade: {2}", student.FirstName, student.LastName, student.Grade);
			}

			Console.WriteLine("\nStudents sorted by grade:");

			foreach (var student in students.OrderBy(s => s.Grade))
			{
				Console.WriteLine("{0,-10} {1,-10} Grade: {2}", student.FirstName, student.LastName, student.Grade);
			}

			Console.WriteLine("\nWorkers:");

			foreach (var worker in workers)
			{
				Console.WriteLine("{0,-11} {1,-11} Salary: {2,-5} Work hours:{3,-4} Money per hour: {4:F2}", worker.FirstName, worker.LastName, worker.WorkSalary, worker.WorkHoursePerDay, worker.MoneyPerHour());
			}

			Console.WriteLine("\nWorkers sorted by money per hour");

			foreach (var worker in workers.OrderByDescending(w => w.MoneyPerHour()))
			{
				Console.WriteLine("{0,-11} {1,-11} Salary: {2,-5} Work hours:{3,-4} Money per hour: {4:F2}", worker.FirstName, worker.LastName, worker.WorkSalary, worker.WorkHoursePerDay, worker.MoneyPerHour());
			}

			var humans = students.Select(s => s as Human).Concat(workers.Select(w => w as Human));

			Console.WriteLine("\n All humans:");

			foreach (var human in humans)
			{
				Console.WriteLine("{0} {1}", human.FirstName, human.LastName);
			}

			Console.WriteLine("\n All humans sorted by first and last name:");

			foreach (var human in humans.OrderBy(h => h.FirstName).ThenBy(h => h.LastName))
			{
				Console.WriteLine("{0} {1}", human.FirstName, human.LastName);
			}
		}
	}
}
