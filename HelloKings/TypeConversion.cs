using System;
namespace HelloKings
{
	public class TypeConversion
	{
		public TypeConversion()
		{
			string character = "2";

			int convertedInt = Convert.ToInt32(character);
			Console.WriteLine(convertedInt);
		}
	}
}

