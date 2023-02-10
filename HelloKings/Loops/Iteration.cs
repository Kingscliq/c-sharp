using System;
namespace HelloKings.Loops
{
	public class Iteration
	{
		public static void EvenAsce(int val)
		{
			for(var i = 0; i < val; i++)
			{
				if(i % 2 == 0)
				{
					Console.WriteLine(i);
				}
			}
		}

		public static void EvenDesc(int val)
		{
			for(var i = 10; i >= val; i--)
			{
				if(i % 2 == 0)
				{
                    Console.WriteLine(i);
                }
			}
		}

		public static void DisplayCharacterStrings(string UserInput)
		{
			foreach(var character in UserInput)
			{
				Console.WriteLine(character);
			}
		}


        public static void DisplayNames()
        {

			var names = new String[] { "john", "Emeka", "SomtoChukwu" };

            foreach (var character in names)
            {
                Console.WriteLine(character);
            }
        }

    }
}

