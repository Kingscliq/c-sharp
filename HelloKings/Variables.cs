using System;
namespace HelloKings;


public class Person
{

	public string firstName;
	public string lastName;

	public void Introduce()
	{
		Console.WriteLine("My FullName is " + firstName + " " + lastName) ;
	}
}
class Variables
	{
    static void Main(string[] args)
	{

		////////////   CLASSESS   ///////////////
		///


		var operators = new Operations.Operators();
		var typeConvert = new TypeConversions.TypeConversion();


		operators.Opera();
		typeConvert.TypeConvert();

		var person = new Person();

		person.firstName = "Kingsley";
		person.lastName = "Ajaezo";

		if(person.firstName == "Kingsley")
		{
			person.Introduce();
		}

	}

}
