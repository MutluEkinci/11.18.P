using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Daire
    {
        public Daire(double r)
        {
            Alan = Math.PI * r * r;
            Cevre = 2 * Math.PI * r;
        }
       // public double r { get; set; }
        public double Alan { get; set; }
        public double Cevre { get; set; }

        public string Yaz()
        {
            return $"Alan={Alan} Cevre={Cevre}";
        }
    }
}
