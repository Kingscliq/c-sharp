using System;
namespace HelloKings.Exercise
{
	public class Fourth
	{
		public static void CalculateSpeed()
		{

			Int64 speedLimit;
            Int64 carSpeed;

			Console.Write("Enter the Speed Limit - ");

			speedLimit =  Convert.ToInt64(Console.ReadLine());

			Console.Write("Enter Car Speed - ");

			carSpeed = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Car xspeed is: {0} and speed Limit is {1} ", carSpeed, speedLimit);

			var demerit = speedLimit / 5;

            if (carSpeed > speedLimit && demerit > 12)
            {
                Console.WriteLine("License Suspended!");
            }
			else
			{
				Console.WriteLine("OK superb Man!");
                return;
			}

            
		}
	}
}

