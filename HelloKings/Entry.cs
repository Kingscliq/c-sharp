﻿using System;
using HelloKings.Maths;
using HelloKings.Exercise;
using HelloKings.Loops;
namespace HelloKings;

class Entry
	{
    static void Main(string[] args)
	{
        //var operators = new Operations.Operators();
        //var typeConvert = new TypeConversions.TypeConversion();

        //      operators.Opera();
        //typeConvert.TypeConvert();

        //var person = new People.Person();
        //var arr = new Arrays.Array();
        //var str = new ManString.ManStrings();
        //var enu = new CSEnums.CsEnums();
        //var types = new CTypes.Ctypes();
        //var somebody = new CTypes.Ctypes();
        //var control = new ControlFlows.Conditionals();
        //var switchs = new ControlFlows.Conditionals();



        //person.firstName = "Kingsley";
        //person.lastName = "Ajaezo";

        //if(person.firstName == "Kingsley")

        //	person.Introduce();
        //	arr.ArrayOut();
        //	str.ManString();
        //	enu.EvaluateEnums();
        //	types.Ctype();
        //	somebody.Ctype();
        //	control.ConditionalStatements();
        //	switchs.Switchs(ControlFlows.Conditionals.Season.Summer);
        //
        //}

        // Answer to First Exercise
        //First.CheckValidNumber(3);

        // Answer to Second Exercise
        //Console.WriteLine("The Maximum number is: {0}", Second.checkMax(7, 2));

        // Answer to Third Exercise
        //Console.WriteLine("This is a {0} ", Third.checkOrientation(800, 400));

        //Fourth.CalculateSpeed();
        //Iteration.EvenAsce(30);
        //Iteration.EvenDesc(4);

        var userInput = Console.ReadLine();

        Iteration.DisplayCharacterStrings(userInput);


    }

}
