using System;

namespace Method
{
    class Program
    {
        internal static void Main(string[] args)
        {
            Calculation cal = new Calculation();
            int num1 = 300, num2 = 300;
            int result = cal.FindMax(num1, num2);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public class Calculation
        {
            public int FindMax(int number1, int number2)
            {
                int result;
                if (number1 > number2) { result = number1; }
                else { result = number2; }

                return result;
            }
        }
    }
}
