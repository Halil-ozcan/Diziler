using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziAlistirma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Uygulama2 : 20 elemanlı bir int dizisi oluşturalım. Değerlerimizi random sınıfının next fonksiyonu ile 1-10 arasindaki değerler
            // ile dolduralım. Daha sonra dizi içerisindeki elemanlarımızı ekrana yazdıralım ve ilgili dizi içerisindeki kaç tane 4 değeri
            // olduğunu bulalım.

            Random rnd = new Random();

            int[] uygulamaDizi2 = new int[20];

            for(int uygulama2Sayac = 0; uygulama2Sayac<uygulamaDizi2.Length; uygulama2Sayac++)
            {
                uygulamaDizi2 [uygulama2Sayac] = rnd.Next(1,10);
            }

            int uygulama2Bul = 0;

            foreach(int item in uygulamaDizi2)
            {
                Console.WriteLine(item);
                if(item==4)
                {
                    uygulama2Bul++;
                }
            }

            Console.WriteLine("Diz İçindeki  4 değeri {0} adettir.", uygulama2Bul);
        }
    }
}
