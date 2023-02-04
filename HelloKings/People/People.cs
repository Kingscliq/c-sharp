using System;
namespace HelloKings.People

{
	public class Person
	{
            public string firstName;
            public string lastName;

            public void Introduce()
            {
                Console.WriteLine("My FullName is " + firstName + " " + lastName);
            }
        }
}

