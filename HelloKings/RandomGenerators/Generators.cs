using System;
namespace HelloKings.RandomGenerators
{
    public class Generators
	{
        public static void RandomNumber()
		{
            Random random = new Random();

            //for(int i = 0; i < 10; i++)
            //{
            //    Console.Write(random.Next(1, 10));
            //}

            //Console.WriteLine();
            //Console.Write((int)'a');

        }

        public static void RandomPassword()
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.Write((char)random.Next(97, 122));
            }


        }

        public static void RandomPasswordString()
        {
            Random random = new Random();

            int passwordLength = 14;
            char[] buffer = new char[passwordLength];

            for (int i = 0; i < 14; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 200));
            }

            var password = new String(buffer);

            Console.WriteLine(password);
        }
    }
}

