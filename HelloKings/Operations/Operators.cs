namespace HelloKings.Operations
{
	public class Operators
	{
		public void Opera()
		{
            //Operators

            int a = 34;
            int b = 12;

            int sum = a + b;

            Console.WriteLine("Sum is " + sum);

            if (sum == 25)
            {
                Console.WriteLine("This is your Silver Jubilee");
            }
            else if (sum < 25)
            {
                Console.WriteLine("You are not yet in your silver jubilee");
            }
            else if (sum > 25 && sum == 50)
            {
                Console.WriteLine("This is your Golden Jubilee");
            }
            else
            {
                Console.WriteLine("None of our values is Matched");
            }

        }
    }
}

