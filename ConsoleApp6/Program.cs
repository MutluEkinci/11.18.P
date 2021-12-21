using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //soru4:bir dairenin alanını ve çevresini hesaplayan sınıfı yazınız.
            Daire d = new Daire(5);
            Console.WriteLine(d.Yaz());
            //soru5:boyutu kullanıcı tarafından belirlenen bir depo nesnesi oluşturunuz.
            Depo depo = new Depo(25);
            //soru6:boyutu kullanıcı tarafından belirlenen dörtgen nesnesi oluşturunuz ve ekrana çiziniz.
            Dortgen dortgen = new Dortgen(10);




        }
    }
}
