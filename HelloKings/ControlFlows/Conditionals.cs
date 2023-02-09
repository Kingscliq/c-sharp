using System;
namespace HelloKings.ControlFlows
{
	public class Conditionals
	{
		public void ConditionalStatements()
		{
			int hour = 12;

			if(hour == 12)
			{
				Console.WriteLine("This is Morning");
			}


			bool isGoldCustomer = true;

			float price = isGoldCustomer ? 19.56f : 29.34f; // Tenary Operators

			Console.WriteLine(price);
		}
	}
}

