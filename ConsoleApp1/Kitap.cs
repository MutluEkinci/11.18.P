using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Kitap
    {
        private int id;
        private string ad;
        private double fiyat;

        public int kitapID
        {
            get { return id; }
            //set { id = value; }
        }
         public string kitapadi
        {
            get { return ad; }
            set { ad = value; }
        }

        public double kitapfiyat
        {
            get { return fiyat; }
            set
            {
                if (value < 0)
                    fiyat = 10.00;
                else fiyat = value;
            }
            
        }
        public string yazar { get; set; }
        public string kategori { get; private set; }
        public int sayfaSayisi { get; set; }
        public string YayinEvi { get; set; }
    }
}
