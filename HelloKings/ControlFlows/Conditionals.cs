using System;
namespace HelloKings.ControlFlows
{
	public class Conditionals
	{

        public enum Season
        {
            Autumn,
            Summer,
            Winter,
            Spring
        }

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

		public void Switchs(Season season)
		{
			switch (season)
			{
				case Season.Autumn:
					Console.WriteLine("This is Autumn Season");
					break;
				case Season.Spring:
                    Console.WriteLine("This is Spring Season");
                    break;
                case Season.Summer:
                    Console.WriteLine("This is Summer Season");
                    break;
                case Season.Winter:
                    Console.WriteLine("This is Winter Season");
                    break;
				default:
					Console.WriteLine("Stay at Home");
					break;
            }

		}

		
	}
}

