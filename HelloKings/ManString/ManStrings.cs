using System;
namespace HelloKings.ManString
{
	public class ManStrings
	{
		public void ManString()
		{
			//

			string firstName = "Ajaezo";
			string lastName = "Kingsley";
			string fullName = string.Format("My fullname is {0} {1}", firstName, lastName);

			string[] names = new string[3] { "John", "Emeka", "Ebuka" };

			var fomattedNames = string.Join(",", names);

			Console.WriteLine(fullName);
            Console.WriteLine(fomattedNames);



        }
	}
}

