using System;
namespace HelloKings.Exercise.Exercise2
{
	public class Sum
	{
		public static void AddNumber()
		{
		    Int32 sum = 0;
			while (true)
			{
				Console.Write("Enter number - ");
				var input = Console.ReadLine();

                if(String.IsNullOrWhiteSpace(input) || input == "ok")
                {
                    Console.WriteLine("Not a number");
                    break;
                }
				else
				{
                    sum += Convert.ToInt32(input);
                    continue;
                   
				}

				
			}

			Console.WriteLine(sum);
		}


		public static void Factorial()
		{
			Console.Write("Enter a Number - ");
			var userInput = Console.ReadLine();
			var ConvertedInput = Convert.ToInt32(userInput);
			int fact = 1;

            if (String.IsNullOrWhiteSpace(userInput))
			{
				Console.WriteLine("Please enter a valid number");
			}
			else
			{
				for(int i = 1; i <= ConvertedInput; i++)
				{
					Console.WriteLine("{0} , {1}", fact, ConvertedInput);
					fact *= i;
				}

                Console.WriteLine("{0}! = {1}", ConvertedInput, fact);
            }
		}

        public static void WordGuessing()
        {

			Random random = new Random();
			int i = 4, Guessed;

			var randomNumber = random.Next(10);

			do
			{
				Console.Write("Enter a Number - ");
				Guessed = Convert.ToInt32(Console.ReadLine());
				i--;
			} while (i >= 4);
    

         
        }
    }
}

