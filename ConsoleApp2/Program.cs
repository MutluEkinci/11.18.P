using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class personel { }
    class kitap
    {
        private static int sayac = 0; //static olduğu zaman sayaç çalıştı.çünkü tek kopyası oldu sayaçın.
        public kitap()
        {
            sayac++;
            Console.WriteLine(sayac);
            Console.WriteLine("Kitap Oluştu...");
        }
        public kitap(string ad)
        {
            sayac++;
            Console.WriteLine(sayac);
            Console.WriteLine("kitap oluştu..." + ad);
        }
        ~kitap()
        {
            sayac--;
            Console.WriteLine(sayac);
            Console.WriteLine("Kitap silindi");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //bir sınıf ramde oluşturulurken ilk çalışan metoda constructor denir.en son çalışana deconstructor denir.class ile aynı isimde ve return type'ı yoktur.bir sınıfta imzası farklı olmak şartıyla n tane yazılabilir. bir sınıfta 1 tane distructor olabilir.gerekmedikçe deconstructor yazmayın. 


            kitap kpt1 = new kitap();
            kitap ktp2 = new kitap("mutlu");
            kitap ktp3 = new kitap();
            Console.ReadLine();


            personel p = new personel();
            




        }
    }
}
