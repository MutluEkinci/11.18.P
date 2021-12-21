using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class personel
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public double Maas { get; set; }
        public string adres { get; set; }
       //public personel()
       // {
       // }
       //public personel(int ıd)
       // {
       // }



        public personel() : this (0,"","",0,"")
        {
        }
        public personel(int id) : this(id, "","",0,"")
        {
        }
        public personel(int id, string ad, string soyad, double maas) : this (id,ad,soyad,maas,"")
        {
        }
        public personel(int id, string ad, string soyad, double maas,string adres)
        {
            PerID = id;
            PerAdi = ad;
            PerSoyad = soyad;
            maas = maas;
            adres = adres;
        }



    }
    class musteri
    {
        public int MusID { get; set; }
        public string MusteriAdi { get; set; }
        public double Cari { get; set; }


    }
    class Program
    {
        static void Main(string[] args)
        {
            personel p1 = new personel();
            p1.ID = 222;
            p1.Ad = "mutlu";
            p1.Soyad = "ekinci";
            p1.Maas = 7500;
            p1.adres = "uskudar";

            personel p2 = new personel(123);
            personel p5 = new personel(345, "cevdet", "korkmaz", 5210, "kadıköy");


            //Object initializer(c# 3.0)

            musteri m1 = new musteri { MusID = 123, MusteriAdi = "", Cari = -100 };
            musteri m2 = new musteri() { MusID = 123, MusteriAdi = "", Cari = -100 };

        }
    }
}
