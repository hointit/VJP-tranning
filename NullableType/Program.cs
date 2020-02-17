using System;

namespace NullableType
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num = null;
            float? mark = null;
            double? price = null;
            num = 5;
            Console.WriteLine(num);
            Console.WriteLine("Mark: " + (mark.HasValue ? mark.Value : 0));
            Console.WriteLine(price ?? 0);
            Console.ReadLine();
        }
    }
}
