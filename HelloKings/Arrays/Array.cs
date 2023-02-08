using System;
namespace HelloKings.Arrays
{
	public class Array
	{
		public void ArrayOut()
		{
			int[] numbers = new int[5];

			numbers[0] = 7;
            numbers[1] = 2;
            numbers[2] = 5;
            numbers[3] = 8;
            numbers[4] = 3;


			Console.WriteLine("{0} {1}", numbers[2], numbers[4]);
        }
	}
}

