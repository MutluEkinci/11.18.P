using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Dortgen
    {
        public Dortgen(int boyut)
        {
            for (int i = 0; i < boyut; i++)
            {
                for (int j=0;j<boyut;j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
