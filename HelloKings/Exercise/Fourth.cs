using System;
namespace HelloKings.Exercise
{
	public class Fourth
	{
		public static void CalculateSpeed()
		{

			int speedLimit;
			int carSpeed;

			Console.WriteLine("Enter the Speed Limit - ");

			speedLimit = Console.Read();

			Console.WriteLine("Enter Car Speed");

            carSpeed = Console.Read();

			Console.WriteLine("Car speed is: {0} and speed Limit is {1} ", carSpeed, speedLimit);

			var demerit = speedLimit / 5;

            if (carSpeed < speedLimit)
            {
                Console.WriteLine("OK superb Man!");
				return;
            }

            if (demerit >= 12)
			{
				Console.WriteLine("License Suspended");
			}
		}
	}
}

