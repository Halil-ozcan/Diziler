using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizilerAlistirma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Uygulama1 : int veri tipinde bir dizi oluşturun. kullanici dizinini kaç elemanlı olduğunu belirlesin ve 
            // dize içerisindeki alanlara değer ataması yapsın. daha sonra dizi içerisindeki elemanların toplamlarını ve ortalamasını yazdırsın.

            Console.WriteLine("Lütfen oluşturmak istediğiniz veri kümesinin uzunluğunu Giriniz");
            string uygulama1DiziUzunluk = Console.ReadLine();
            int ugulamaDiziUzunlukint = int.Parse(uygulama1DiziUzunluk);

            int[] uygulama1Dizi = new int[ugulamaDiziUzunlukint];

            for(int uygulamaSayac = 0;  uygulamaSayac < uygulama1Dizi.Length; uygulamaSayac++)
            {
                Console.WriteLine("{0} . index e denk gelen degeri giriniz", uygulamaSayac);
                uygulama1Dizi[uygulamaSayac] = int.Parse(Console.ReadLine());   
            }

            Console.WriteLine("Tebrikler dizinin içerisindeki tüm alanları doldurdunuz.");

            Console.WriteLine("Dizi içerisindeki degerler ve toplam, ortalama degeri asağıdaki gibidir.");

            int uygulamaToplam =0 , uygulamaOrtalama = 0;
            foreach(int item in uygulama1Dizi)
            {
                Console.WriteLine(item);
                uygulamaToplam = uygulamaToplam + item;
            }


            Console.WriteLine("---------------------------------------");

            Console.WriteLine(uygulamaToplam);

            Console.WriteLine("Dizi İçerisindeki eleman Sayısı : {0} ", uygulama1Dizi.Length);
            uygulamaOrtalama = uygulamaToplam / uygulama1Dizi.Length;
            Console.WriteLine("Ortalama : {0} ", uygulamaOrtalama);
        }
    }
}
