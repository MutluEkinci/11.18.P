using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._11_Perşembe
{
    class Personel
    {
        private int ID;
        private string Ad;
        private double Maas;

        //public int ID;
        //public string Ad;
        //public double Maaş;


        public string getAd()
        {
            return Ad;
        }
        public void setAd(string ad)
        {
            Ad = ad;
        }

        //3.0 Öncesi property

        public int PersonelID
        {
            get { return ID; } //get => ID; //3.0 öncesi kullanıyorsak propertynin kullandığı değişkeni de biz tanımlarız.
            set { ID = value; }//3.0 sonrası get ve set e code yazılamaz o yüzden bazı durumlarda 3.0 öncesi kullanılır.
        }
        //3.0 ve sonrası
        public string Adres { get; set; }
        //ihtiyacı olan değişkeni kendisi tanımlar.propertyler asla kendi üzerinde değer tutmaz.property aracıdır.

        //3.0 sonrası için proprety kendisi değişken oluşturur biz oluşturmayız.
        //property yazarken sonunda () olmaz,onun yerine {} kullanılır.yoksa metodla karıştılırdı.
    }
    class Program
    {
        static void Main(string[] args)
        {
            //class ve object arasındaki fark class bir şablondur object ise bu şablonun aktif olarak ramde oluşmuş haline denir.yani object somuttur.
            //Personel p = new Personel();"ınstance"=>somut örneklemedir.ev örneği gibi.senin tüm odalarının resmi kafanda bellidir ama inşaat bitmeden elinde somut bir örnek olmaz.
            //her şey object sınıfından türemiştir.
            //bir class içerisinde ya da seviyesinde herhangi bir member'ın erişim belirleyicisi belirtilmemişse private'tır.
            //field=değişken
            //property c#3.0 öncesi ve sonrasında farklı yazılır.

            Personel p = new Personel();
            p.PersonelID = 12; //property aynen değişkenler gibi yazılır.
            Console.WriteLine(p.PersonelID);


            p.Adres = "mutlu";
            Console.WriteLine(p.Adres);

            
            Random rnd = new Random();

            
        }
    }
}
