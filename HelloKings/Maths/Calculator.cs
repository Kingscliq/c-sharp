using System;
namespace HelloKings.Maths
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public float Divide(int a, int b)
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
        public int Minus(int a, int b)
        {
            return a - b;
        }
    }
}

