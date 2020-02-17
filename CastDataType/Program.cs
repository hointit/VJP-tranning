using System;

namespace CastDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 1;
            int b;
            b = a;
            int a1 = 123;
            byte b1;
            b1 = (byte)a1;
            //
            string name = "121212";
            int nameint = Convert.ToInt32(name);
            //
            string date = "30/1/2015";
            DateTime dateTime = Convert.ToDateTime(date);
            //
            string p1 = "12121";
            int p2 = int.Parse(p1);
            //
            string x1 = "true";
            bool x2 = bool.Parse(x1);

            string num = "121212";
            int resultNum;
            bool parse = int.TryParse(num, out resultNum);
            Console.WriteLine("{0},{1}", resultNum, parse);
            Console.WriteLine(p2);
            Console.WriteLine(x2);
            Console.WriteLine(dateTime.ToLongDateString());
            Console.WriteLine(b);
            Console.WriteLine(b1);
            Console.ReadLine();
        }
    }
}
