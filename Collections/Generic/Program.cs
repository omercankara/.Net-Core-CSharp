using System;


class Program
{
    class Product
    {
        public string Name { get; set; } = string.Empty;
    }
    static void Main(string[] args)
    {
        //generic list içerik tipi belirtilerek kullanılır.
        List<int> sayilar = new List<int>();
        List<string> isimler = new List<string>();

        List<Product> urunler = new List<Product>(){
            new Product(){Name="Bilgisayar"}
         };
        sayilar.Add(5);
        isimler.Add("Ömercan");
        isimler.Add("Eda");
        isimler.Add("Ada");

        foreach (var item in isimler)
        {
            Console.WriteLine(item);
        }

        foreach (var item in sayilar)
        {
            Console.WriteLine(item);
        }

         foreach (var item in urunler)
        {
            Console.WriteLine(item.Name);
        }

    }
}