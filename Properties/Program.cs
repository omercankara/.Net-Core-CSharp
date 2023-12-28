using System;

class Program
{
    class Product
    {
        private string _name;
        private double _price;


        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
                {
                    Console.WriteLine("Name Alanı boş");
                }
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0)
                {
                    _price = 0;
                }
                else
                {
                    _price = value;
                }
            }
        }

    }
    static void Main(string[] args)
    {
        Product urun = new Product();
        {
            urun.name = "C4N";
            urun.Price = 2000;
        }
        Console.WriteLine(urun.Price);
        Console.WriteLine(urun.name);
    }
}