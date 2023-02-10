using System;
namespace HelloKings.Loops
{
	public class Iteration
	{
		public static void EvenAsce(int val)
		{
			//for(var i = 0; i < val; i++)
			//{
			//	if(i % 2 == 0)
			//	{
			//		Console.WriteLine(i);
			//	}
			//}
			int i = 0;
			while(i <= val)
			{

                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                  
                }

                i++;
              
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

        public static void EchoNames()
        {

			while (true)
			{
				Console.Write("Type your name - ");

				var userInput = Console.ReadLine();

				if (!String.IsNullOrWhiteSpace(userInput))
				{
					Console.WriteLine("Your name is {0}", userInput);
					continue;
				}
				else
				{
					Console.WriteLine("No Name Entered");
				}
                break;



            }
        }

    }
}

