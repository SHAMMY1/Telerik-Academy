using Animals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Dog> dogs = new List<Dog>()
			{
				new Dog("Marco", 4,Sex.Female),
				new Dog("Apollo", 4.5,Sex.Female),
				new Dog("Argos", 3.5,Sex.Female),
				new Dog("Armani", 2,Sex.Female),
				new Dog("Leia", 3, Sex.Female),
				new Dog("Adia", 3.5, Sex.Female),
				new Dog("Maci", 7, Sex.Female),
				new Dog("Ann", 5, Sex.Female),
			};

			List<Frog> frogs = new List<Frog>()
			{
				new Frog("Anita", 0.8, Sex.Female),
				new Frog("Anika", 0.5, Sex.Female),
				new Frog("Ariel", 1.2, Sex.Female),
				new Frog("Aries", 1.4, Sex.Female)
			};

			List<Kitten> kittens = new List<Kitten>()
			{
				new Kitten("Asta", 2),
				new Kitten("Marcia", 2.5),
				new Kitten("Mary", 1.5),
				new Kitten("Bambi", 1),
				new Kitten("Meg", 0.5),
			};

			List<Tomcat> tomcats = new List<Tomcat>()
			{
				new Tomcat("Aladdin", 1.5),
				new Tomcat("Amos", 2.5),
				new Tomcat("Mago", 3),
				new Tomcat("Angelo", 2),
				new Tomcat("Major", 1.5),
			};

			Console.WriteLine("Dogs average age: {0:f1} years", dogs.Average(d => d.Age));
			Console.WriteLine("Frogs average age: {0:f1} years", frogs.Average(f => f.Age));
			Console.WriteLine("Kittens average age: {0:f1} years", kittens.Average(k => k.Age));
			Console.WriteLine("Tomcats average age: {0:f1} years", tomcats.Average(t => t.Age));
		}
	}
}
