using System;
namespace HelloKings.Maths
{
    public class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static float Divide(int a, int b)
        {
            if (a > b)
            {
                return a / b;
            }
            else
            {
                return b / a;
            }

        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }
}

