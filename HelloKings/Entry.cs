using System;
using HelloKings.Maths;
namespace HelloKings;


class Entry
	{
    static void Main(string[] args)
	{
		var operators = new Operations.Operators();
		var typeConvert = new TypeConversions.TypeConversion();

        operators.Opera();
		typeConvert.TypeConvert();

		var person = new People.Person();
		var arr = new Arrays.Array();
		var str = new ManString.ManStrings();


		person.firstName = "Kingsley";
		person.lastName = "Ajaezo";

		if(person.firstName == "Kingsley")
		{
			person.Introduce();
			arr.ArrayOut();
			str.ManString();
		}



	}

}
