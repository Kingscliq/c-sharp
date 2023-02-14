using System;
namespace HelloKings.Strings
{
	public class StringMethods
	{
		public static void ManipulateString()
		{
			var fullName = "Ajaezo Kingsley";

			var names = fullName.Split(' ');
			Console.WriteLine("FirstName: {0}", names[0]);
            Console.WriteLine("LastName: {0}", names[1]);
        }

	}
}

