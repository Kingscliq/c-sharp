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

			Console.WriteLine("Total numbers of elements is: {0}", numbers.Count);
			numbers.Remove(8);

            Console.WriteLine("Does numbers contain 45? {0}", numbers.Contains(45));
          

			for(int i = 0; i < numbers.Count; i++)
			{
				if (numbers[i] == 6)
				{
					numbers.Remove(numbers[i]);
				}
			}

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}

