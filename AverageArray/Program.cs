using System;

namespace AverageArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Array arr = new Array();
            ParamArr paramArr = new ParamArr();
            int[] number = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 222 };
            float _average = arr.AverageArray(number, number.Length);
            float _paramarr = paramArr.AddElement(number);
            Console.WriteLine(_paramarr);
            Console.ReadLine();
        }
    }
    class Array
    {
        public float AverageArray(int[] _arr, int _size)
        {
            int _sum = 0;
            for (int i = 0; i < _size; i++)
            { _sum += _arr[i]; }
            float _average = _sum / _size;
            return _average;
        }
    }
    class ParamArr
    {
        public int AddElement(params int[] arr)
        {
            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }
            return sum;

        }
    }
}
