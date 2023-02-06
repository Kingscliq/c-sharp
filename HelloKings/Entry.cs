using System;
namespace HelloKings;

class Entry
	{
    static void Main(string[] args)
	{
		var operators = new Operations.Operators();
		var typeConvert = new TypeConversions.TypeConversion();
		var calculator = new Maths.Calculator();

		Console.WriteLine("Sum for this expression is " + calculator.Add(5, 8));
        Console.WriteLine("Answer for this expression is " + calculator.Divide(5, 8));
        Console.WriteLine("Answer for this expression is " + calculator.Minus(5, 8));
        Console.WriteLine("Answer for this expression is " + calculator.Multiply(5, 8));

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
