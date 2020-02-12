using System;

namespace StructType
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact _contact = new Contact();
            _contact._address = "Ho Chi Minh";
            _contact._creditCard = 21256;
            _contact._gender = true;
            _contact._birthday = DateTime.Parse("12/02/2020");
            _contact.Print();
            Console.ReadLine();
        }
    }
    public struct Contact
    {
        public string _address;
        public int _creditCard;
        public bool _gender;
        public DateTime _birthday;
        public void Print()
        {
            Console.WriteLine(_address);
            Console.WriteLine(_creditCard);
            Console.WriteLine(_gender?"Male":"Female");
            Console.WriteLine(_birthday.ToString("dd/MM/yyyy"));
        }
    }
}
