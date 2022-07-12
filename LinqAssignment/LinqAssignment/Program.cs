using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
	public class Program
	{
		public static void Main(string[] args)
		{
			PracticeQues practiceQues = new PracticeQues();
			practiceQues.Practice();
			//Person person = new Person();
			//person.Handson();
			//person.BankDetails();
			
			/*var people = new List<Person>()
		{
			new Person("Bill", "Smith", 41),
			new Person("Sarah", "Jones", 22),
			new Person("Stacy","Baker", 21),
			new Person("Vivianne","Dexter", 19 ),
			new Person("Bob","Smith", 49 ),
			new Person("Brett","Baker", 51 ),
			new Person("Mark","Parker", 19),
			new Person("Alice","Thompson", 18),
			new Person("Evelyn","Thompson", 58 ),
			new Person("Mort","Martin", 58),
			new Person("Eugene","deLauter", 84 ),
			new Person("Gail","Dawson", 19 ),

		};
			var result = from d in people
						 where d.LastName.StartsWith("D")
						 select d;
			foreach (var item in result)
			{
				Console.WriteLine(item.LastName);

			}
			int c = (from d in people
					 where d.LastName.StartsWith("D")
					 select d).Count();
			Console.WriteLine("Count = " + c);
			var result1 = from d in people
						  where d.Age > 40
						  orderby d.FirstName descending
						  select d;
			foreach (var item in result1)
			{
				Console.WriteLine(item.FirstName);

			}
			var result2 = from d in people
						  select d.FirstName + " " + d.LastName;
			foreach (var item in result2)
			{
				Console.WriteLine(item);
			}*/

			Console.Read();
		}
		public class Person1
		{
			public Person1(string firstName, string lastName, int age)
			{
				FirstName = firstName;
				LastName = lastName;
				Age = age;
			}

			public string FirstName { get; set; }
			public string LastName { get; set; }
			public int Age { get; set; }

			//override ToString to return the person's FirstName LastName Age
		}
	}
}
		


