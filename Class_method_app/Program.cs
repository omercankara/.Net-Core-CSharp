using System;


class Program
{
    class Araba
    {
        public string marka { get; set; } = string.Empty;
        public string model { get; set; } = string.Empty;

        public string renk { get; set; } = string.Empty;
        public bool otomotik { get; set; }

        public void start()
        {
            Console.WriteLine($"{marka} Araba çalıştı");
        }
        public void stop()
        {
            Console.WriteLine($"{marka} Araba Stop Etti");
        }

        public void Slow()
        {
            Console.WriteLine($"{marka} Araç Yavaşladı");
        }

        public void SpeedUp()
        {
            Console.WriteLine($"{marka}Araç hızlandı");
        }

        public void Menu()
        {
            string komut = "";
            do
            {
                Console.Write("Seçiminiz: 1-start 2-Hizlan 3-Yavaşla 4-Dur 5-Çıkış");
                komut = Console.ReadLine();
                switch (komut)
                {
                    case "1":
                        start();
                        break;
                    case "2":
                        stop();
                        break;
                    case "3":
                        Slow();
                        break;
                    case "4":
                        SpeedUp();
                        break;
                    default:
                        Console.WriteLine("Sonlandım");
                        break;
                }



            } while (komut != "Ç");
        }

    }
    static void Main(string[] args)
    {
        Araba ferrari = new Araba();
        {
            ferrari.marka = "Ferrari";
            ferrari.model = "458 İtalia";
            ferrari.renk = "Kırmızı";
            ferrari.otomotik = true;
        }
        ferrari.Menu();


        Araba hyundai = new Araba();
        {
            hyundai.marka = "Hyundai";
            hyundai.model = "i30";
            hyundai.renk = "Kırmızı";
            hyundai.otomotik = true;
        }

        hyundai.Menu();
    }


}