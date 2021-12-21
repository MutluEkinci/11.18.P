using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class personel
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string adres { get; set; }
        public double Maas { get; set; }

        public personel(int id)
        {
            ID = id;
            Console.WriteLine("15621");
        }
        public personel(string Ad, string soyad)
        {
            Ad = Ad;
            soyad = soyad;
            Console.Write("Mutlu");
            Console.Write("Ekinci");
        }
        public personel(double maas)
        {
            maas = maas;
            Console.WriteLine("7500");
        }
        public personel()
        {
            Console.WriteLine(" ");
        }
        public personel(string adres)
        {
            adres = adres;
            Console.WriteLine("kuşbaşı sok.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Soru2:5 özelliği olan bir personel sınıfı yazınız ve bu sınıf için 5 farklı ctor yazınız.
            //???bir sınıfta property varse neden ctor var?

            personel p1 = new personel();
            p1.ID = 222;
            p1.Ad = "mutlu";
            p1.Soyad = "ekinci";
            p1.Maas = 7500;
            p1.adres = "uskudar";

            personel p2 = new personel(123);
            personel p5 = new personel(345, "cevdet", "korkmaz", 5210, "kadıköy");
        }
    }
}
