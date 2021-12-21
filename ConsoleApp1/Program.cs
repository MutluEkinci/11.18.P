using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class sınıf
    {
        int sayfa;
        string basHarf;
        double tarih;
        string dil;
        



        public int sınıfsayfa
        {
            get { return sayfa; }
            set { sayfa = value; }

        }

        public string sınıfbasHarf
        {
            get { return basHarf; }
            set { basHarf = value; }

        }

        public double sınıftarih
        {
            get { return tarih; }
            set { tarih = value; }

        }

        public string sınıfdil
        {
            get { return dil; }
        }

        public string yazar { get; set; }
        public string yayınevi { get; set; }
        public int ID { get; set; }


    }
    class Program
    {
        static void Main(string[] args)
        {
            //Soru1:Bir kitap sınıfı oluşturunuz.7 adet özellik tanımlayınız.Bunlardan 3 tanesi 3.0 öncesi olmalı.bir tanesi ise sadece okunabilir olmalı.Bir özelliğe de kısıt ekleyin.bu sınıfı tasarlayınız.

            Kitap kitap = new Kitap();
            //kitap.kitapID = 123;
            kitap.kitapadi = "denemeler";
            //kitap.kategori = "Deneme";
            kitap.kitapfiyat = -50;
            Console.WriteLine(kitap.kitapfiyat);
            kitap.kitapfiyat = 25;
            Console.WriteLine(kitap.kitapfiyat);
            kitap.sayfaSayisi = 365;
            kitap.YayinEvi = "tomurcuk yayınevi";

            sınıf sınıf = new sınıf();
            sınıf.sınıfbasHarf = "e" ;


        }
    }
}
