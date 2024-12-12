using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ogrenciListesi = new string[5];

            ogrenciListesi[0] = "Halil";
            ogrenciListesi[1] = "Hasan";
            ogrenciListesi[2] = "Kemal";
            ogrenciListesi[3] = "Hakan";
            ogrenciListesi[4] = "Deniz";

            foreach (var item in ogrenciListesi)
            {
                Console.WriteLine(item);
            }

            for(int i = 0; i < ogrenciListesi.Length; i++)
            {
                string gelenİsim = ogrenciListesi[i];
                Console.WriteLine(gelenİsim);
            }
        }
    }
}
