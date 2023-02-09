using System;
namespace HelloKings.Exercise
{
	public class First
	{
		public static void CheckValidNumber(int num)
		{
			if(num > 0 && num <= 10)
			{
				Console.WriteLine("Valid!");
			}
			else
			{
                Console.WriteLine("InValid!");
            }
		}
	}
}

