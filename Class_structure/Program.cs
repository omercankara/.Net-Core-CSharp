using System;
using System.ComponentModel;

namespace consoleApp
{
    class Ogrenci
    {
        public int ogrNo { get; set; }
        public string ad_soyad { get; set; } = string.Empty; //string empty ile boş olabilir değeri ver
        public string sube { get; set; } = string.Empty;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr1 = new Ogrenci();
            ogr1.ad_soyad = "Eda";
            ogr1.ogrNo = 374;
            ogr1.sube = "10/A";
            Console.WriteLine($"İsim:{ogr1.ad_soyad}");


            Ogrenci ogr2 = new Ogrenci
            {
                ogrNo = 200,
                ad_soyad = "Seda",
                sube = "10/C"
            };
            Console.WriteLine($"İsim:{ogr2.ad_soyad}");

            Console.WriteLine("***************DİZİ OLUŞTUR VE DÖNGÜ İLE YAZ*******************");
            Ogrenci[] ogrenciler = new Ogrenci[2];
            ogrenciler[0] = ogr1;
            ogrenciler[1] = ogr2;
            foreach (var item in ogrenciler)
            {
                Console.WriteLine(item.ad_soyad);
            }
        }
    }
}