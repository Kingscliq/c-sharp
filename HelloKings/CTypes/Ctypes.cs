using System;
namespace HelloKings.CTypes
{

	public class Person
	{
		public int Age;
	}

	public class Ctypes
	{
		public void Ctype()
		{
			// Value Types
			int a = 4;
			int b = a;
			b++;

		Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));


		var array1 = new int[4] { 1, 3, 5, 7};
		var array2 = array1;

		array2[0] = 10;

		Console.WriteLine(string.Format("first element of array1 is {0} and array2 is {1}", array1[0], array2[0]));
			var person = new Person() { Age = 60 };


			MakeOld(person);

			Console.WriteLine("My age is {0}", person.Age);
		}

		public static void MakeOld(Person person)
		{
			person.Age += 23;
		}

	}
}

