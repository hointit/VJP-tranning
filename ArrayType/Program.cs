using System;

namespace ArrayType
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            arr[0] = 0;
            arr[2] = 1;
            string[] name = new string[] { "Hoang", "An" };
            int[,] _int = new int[,]
            {
                {1,3,2,4 },
                {1,1,1,1 },
                {2,2,2,2 }
            };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                { Console.WriteLine(_int[i, j]); }
            }
            Console.ReadLine();

        }
    }
}
