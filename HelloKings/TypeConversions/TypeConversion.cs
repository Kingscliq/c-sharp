using System;

namespace HelloKings.TypeConversions;

public class TypeConversion
{
	public void TypeConvert()
	{
		string character = "2";

		int convertedInt = Convert.ToInt32(character);
		Console.WriteLine(convertedInt);
	}
}

