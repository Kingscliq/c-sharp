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
	}
}

