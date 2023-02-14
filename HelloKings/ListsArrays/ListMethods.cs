using System;
namespace HelloKings.ListsArrays
{
	public class ListMethods
	{
		public static void ListMethod()
		{
			var numbers = new List<int>() { 1, 4, 6,7,8};

			numbers.Add(3);

			foreach(int num in numbers)
			{
				Console.WriteLine(num);
			}

			//Console.WriteLine(numbers);
		}
	}
}

