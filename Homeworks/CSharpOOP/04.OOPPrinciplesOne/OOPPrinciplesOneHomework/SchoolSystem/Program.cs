using SchoolSystem.Interfaces;
using SchoolSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
	class Program
	{
		static void Main(string[] args)
		{
			School school = new School("MySchool");

			SchoolClass myClass = new SchoolClass();

			Teacher myTeacher = new Teacher("PetarPetrov");

			myTeacher.AddDiscipline(new Discipline("OOP", 4, 4));
			myTeacher.AddDiscipline(new Discipline("JavaScript", 3, 3));

			myClass.AddStudent(new Student("Ivancho", 0001));
			myClass.AddStudent(new Student("Mariika", 0002));

			myClass.AddTeacher(myTeacher);

			school.AddClass(myClass);

			Console.WriteLine(school);

		}
	}
}
