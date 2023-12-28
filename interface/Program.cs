using System;

namespace ConsoleApp
{
    interface IKisi
    {
        string adSoyad { get; set; }
        string adres { get; set; }
        string departman { get; set; }
        double maas { get; set; }

    }
    interface IPersonel
    {
        string departman { get; set; }
        void bilgi();
    }
    class Yonetici : IPersonel, IKisi
    {
        public Yonetici(string _adSoyad, string adress, string _departman, double maas)
        {
            this.adSoyad = _adSoyad;
            this.adres = adress;
            this.departman = _departman;
            this.maas = maas;
        }
        public string adSoyad { get; set; }
        public string adres { get; set; }
        public string departman { get; set; }
        public double maas { get; set; }

        public void bilgi()
        {
            Console.WriteLine($"{this.adSoyad} isimli personel {this.departman} Bölümünde yönetici Maaş {this.maas}");
        }
    }
    class Iscı : IPersonel, IKisi
    {
        public Iscı(string _adSoyad, string adress, string _departman, double maas)
        {
            this.adSoyad = _adSoyad;
            this.adres = adress;
            this.departman = _departman;
            this.maas = maas;
        }
        public string adSoyad { get; set; }
        public string adres { get; set; }
        public string departman { get; set; }
        public double maas { get; set; }

        public void bilgi()
        {
            Console.WriteLine($"{this.adSoyad} isimli personel {this.departman} Bölümünde İşcidir. Maaş {this.maas}");
        }
    }
    class Robot : IPersonel
    {
        public Robot(string departman)
        {
            this.departman = departman;
        }
        public string departman { get; set; }

        public void bilgi()
        {
            Console.WriteLine($" Robot Departmanı: {this.departman}");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var personeller = new IPersonel[3];
            personeller[0] = new Yonetici("Ali", "İstanbul", "finans", 5000);
            personeller[1] = new Iscı("Ahmet", "Kocaeli", "Uretim", 3000);
            personeller[2] = new Yonetici("Ali", "İstanbul", "finans", 2500);
            personeller[2] = new Robot("Üretim");
            foreach (var item in personeller)
            {
                item.bilgi();
            }
        }
    }
}

