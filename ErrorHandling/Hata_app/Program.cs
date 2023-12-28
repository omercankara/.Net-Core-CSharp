using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // "1","2","5a","10b","abc","10","50"
            // 1 - Liste içerisindeki sayısal değerleri bulunuz
            var liste = new List<string>()
            {
                "1","2","5a","10b","abc","10","50"
            };
            foreach (var item in liste)
            {
                try
                {
                    int a = int.Parse(item);
                    Console.WriteLine(a);
                }
                catch (Exception ex)
                {
                    continue;
                }
            }

            // 2 - Kullanıcı "q" Değerini girmedikce aldığınız her değerin
            // sayısal olup olmadığını kontrol ediniz aksi halde hata mesajı verin

            while (true)
            {
                Console.WriteLine("Sayı: ");
                string input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try
                {
                    int sayi = int.Parse(input);
                    Console.WriteLine($"Girdiniz sayi {sayi}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Geçersiz Sayı Girdiniz");
                    continue;
                }
            }


        }


    }
}

