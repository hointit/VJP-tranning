using System;

namespace GiaiThua
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation cal = new Calculation();
            int a = cal.TinhGiaiThua(3);
            Console.WriteLine(a);
            Console.ReadLine();

        }
        class Calculation
        {
            public int TinhGiaiThua(int a)
            {
                int cal;
                if (a == 1)
                { return 1; }
                else
                {
                    cal = TinhGiaiThua(a - 1) * a;
                    return cal;
                }
            }
        }
    }
}
