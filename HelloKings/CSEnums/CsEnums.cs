using System;
namespace HelloKings.CSEnums

{

	public enum ShippingMethods
	{
		RegularAirmail = 3,
		RegisteredAirmail = 2,
		Express = 4
	}

	public class CsEnums
	{
		
		public void EvaluateEnums()
		{
			//var method = ShippingMethods
			Console.WriteLine((int)ShippingMethods.Express);
            Console.WriteLine((ShippingMethods)3); // I put 5 here and it didnt throw any errors, it just returned the value
        }
	}
}

