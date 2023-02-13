using System;
namespace HelloKings.Arrays
{
	public class ArrayMethods
	{


        public int [] numbers = new int[8] { 1, 2, 3, 5, 78, 32, 42, 4 };

        public static void ArrayOut()
		{
			int[] numbers = new int[5];

			numbers[0] = 7;
            numbers[1] = 2;
            numbers[2] = 5;
            numbers[3] = 8;
            numbers[4] = 3;


			Console.WriteLine("{0} {1}", numbers[2], numbers[4]);
        }

		public void FindLength()
		{

			Console.WriteLine("Length is: {0} ", numbers.Length);
			
		}

		public void FindIndex()
		{

			var index = Array.IndexOf(numbers, 78);

			Console.WriteLine("Index of 78 is: ", index );
			
		}

		public void UseCLear()
		{

		}
	}
}

