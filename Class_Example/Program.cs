using System;

namespace consoleApp
{
    // product class => Name,price,description
    //Sınırsız sayıda ürün bilgisini alıp diziye pushla
    //ürün adetini kullanıcı girsin
    //Eklenen ürünleri listele
    class Product
    {
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
        public string description { get; set; } = string.Empty;
    }
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Adet:");
            int adet = int.Parse(Console.ReadLine());

            Product[] products = new Product[adet];

            int i = 0; //döngü sayısı adet kadar döngü oluşturur
            Product prd; // product sınıfından nesne oluştur 

            do
            {
                prd = new Product();
                Console.Write("Ürün Adı: ");
                prd.Name = Console.ReadLine();

                Console.Write("Ürün Fiyatı: ");
                prd.Price = double.Parse(Console.ReadLine());

                Console.Write("Açıklama Giriniz:");
                prd.description = Console.ReadLine();

                products[i] = prd;
                i++;


            } while (i < adet); //adet değeri kadar döngü oluştur 
            Console.WriteLine("***********");

            foreach (var item in products)
            {   
                Console.WriteLine($" Ürün Adı: {item.Name} Ürün Fiyatı. {item.Price} Ürün Açıklaması {item.description}");
            }

        }
    }
}