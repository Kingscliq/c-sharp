﻿using System;

namespace HelloKings;

	class Variables
	{
    static void Main(string[] args)
	{
		byte number = 0;
		string firstName = "Kingsley";
		bool isPlaying = false;
		Console.WriteLine(number);

		Console.WriteLine("Is " + firstName + " Playing " + "The asnwer is " + isPlaying);

        string character = "2";

        int convertedInt = Convert.ToInt32(character);
        Console.WriteLine(convertedInt);
    }  
	
	}