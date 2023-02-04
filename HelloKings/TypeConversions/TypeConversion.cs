using System;

namespace HelloKings.TypeConversions;

public class TypeConversion
{
	public void TypeConvert()
	{
        byte number = 0;
        string firstName = "Kingsley";
        bool isPlaying = false;
        Console.WriteLine(number);

        Console.WriteLine("Is " + firstName + " Playing " + "The answer is " + isPlaying);

        string character = "2";

        int convertedInt = Convert.ToInt32(character);
        Console.WriteLine(convertedInt);
        try
        {
            string series = "123";
            int b = Convert.ToInt32(series);
            Console.WriteLine(b);

        }
        catch (Exception)
        {
            Console.WriteLine("The byte type cannot be converted to an integer");

        }
    }
}

