using System;

namespace StringExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "TEDU";
            char[] _char = new char[] { 'a','b'};
            string _name1 = new string(_char);
            string _mark = 10.ToString();
            Console.WriteLine(name.Length);
            Console.ReadLine();
    }
}
