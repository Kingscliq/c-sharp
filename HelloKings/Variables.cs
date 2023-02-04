using System;

namespace HelloKings;

	class Variables
	{
    static void Main(string[] args)
	{
		//byte number = 0;
		//string firstName = "Kingsley";
		//bool isPlaying = false;
		//Console.WriteLine(number);

		//Console.WriteLine("Is " + firstName + " Playing " + "The answer is " + isPlaying);

		//string character = "2";

		//int convertedInt = Convert.ToInt32(character);
		//Console.WriteLine(convertedInt);


		//try
		//{
		//	string series = "123344";
		//	byte b = Convert.ToByte(series);
		//	Console.WriteLine(b);

		//}
		//catch (Exception)
		//{
		//	Console.WriteLine("The string type cannot be converted to an integer");

		//}


		//Operators

		int a = 34;
		int b = 12;

		int sum = a + b;

		Console.WriteLine("Sum is " + sum);

		if(sum == 25)
		{
			Console.WriteLine("This is your Silver Jubilee");
		}
		else if(sum < 25)
		{
			Console.WriteLine("You are not yet in your silver jubilee");
		}else if(sum > 25 && sum == 50)
		{
			Console.WriteLine("This is your Golden Jubilee");
		}
		else
		{
			Console.WriteLine("None of our values is Matched");
		}


	}

}
