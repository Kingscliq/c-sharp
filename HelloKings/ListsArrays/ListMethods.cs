using System;
namespace HelloKings.ListsArrays
{
	public class ListMethods
	{
		public static void ListMethod()
		{
			var numbers = new List<int>() { 1, 4, 6,7,8};

			numbers.Add(3);
			numbers.AddRange(new int[]{ 4,6,7,45});

			foreach(int num in numbers)
			{
				Console.WriteLine(num);
			}


			Console.WriteLine();
            Console.WriteLine("Index of 6 is: {0} ", numbers.IndexOf(6));

        }
	}
}

