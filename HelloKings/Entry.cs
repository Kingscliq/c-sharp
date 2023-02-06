using System;
using HelloKings.Maths;
namespace HelloKings;


class Entry
	{
    static void Main(string[] args)
	{
		var operators = new Operations.Operators();
		var typeConvert = new TypeConversions.TypeConversion();
		
		Console.WriteLine("Sum for this expression is " + Calculator.Add(5, 8));
        Console.WriteLine("Answer for this expression is " + Calculator.Divide(5, 8));
        Console.WriteLine("Answer for this expression is " + Calculator.Minus(5, 8));
        Console.WriteLine("Answer for this expression is " + Calculator.Multiply(5, 8));

        operators.Opera();
		typeConvert.TypeConvert();


		var person = new People.Person();

		person.firstName = "Kingsley";
		person.lastName = "Ajaezo";

		if(person.firstName == "Kingsley")
		{
			person.Introduce();
		}



	}

}
