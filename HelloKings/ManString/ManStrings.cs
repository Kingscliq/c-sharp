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

			Console.WriteLine(fullName);



		}
	}
}

