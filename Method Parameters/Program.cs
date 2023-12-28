using System;


class Program
{
    class Islem
    {
        /*  public int x { get; set; }
         public int y { get; set; } */
        /* public int top(int x, int y)
        {
            Console.WriteLine("x "+ x);
            return x + y;
        } */
    }
    class Araba
    {
        public string Marka { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Renk { get; set; } = string.Empty;
        public Boolean otomotik { get; set; }
        public void start()
        {
            Console.WriteLine($"{Marka} Araba çalıştı");
        }
        public void stop()
        {
            Console.WriteLine($"{Marka} Araba Stop Etti");
        }

        public void Slow()
        {
            Console.WriteLine($"{Marka} Araç Yavaşladı");
        }

        public void SpeedUp()
        {
            Console.WriteLine($"{Marka} Araç Hızlandı");
        }
    }
   /*  static void Main(string[] args)
    {
        Islem islem = new Islem();

        Console.WriteLine(islem.Toplama(20,20));
    } */
}