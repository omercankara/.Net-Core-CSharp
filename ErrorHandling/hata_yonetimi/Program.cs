using System;

class Program
{
    // Hata
    class Product
    {
        public string Name { get; set; } = string.Empty;
    }

    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("A:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("B:");
            int b = int.Parse(Console.ReadLine());

            var sonuc = a / b;
            Console.WriteLine($"{a} / {b} = {sonuc}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("B Değeri 0 olamaz");

        }
        catch (FormatException)
        {
            Console.WriteLine("Karakter değeri girdiniz");
        }
        finally
        {
            Console.WriteLine("Final Çalisti");
        }

    }
}
