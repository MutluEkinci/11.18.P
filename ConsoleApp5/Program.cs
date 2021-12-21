using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Uye
    {
        public string username { get; set; }
        public string password { get; set; }

        public int rolID { get; set; }
        public Uye(string user ,string pass,int rolID)
        {

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Uye uye = new Uye("", "");
        }
    }
}
