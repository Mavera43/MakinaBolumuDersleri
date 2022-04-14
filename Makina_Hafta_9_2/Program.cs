using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makina_Hafta_9_2
{
    class Program
    {
        //değişken sayıda parametre alan metodlar / params parametresi kullanımı
  

        static void ekle(out int sayi)
        {
            sayi = 55;
            sayi += 5;
            
        }

        static void Outhesapla(int[] sayilar, out double toplam, out double ortalama )
        {
            toplam = 0;ortalama = 0;
            foreach (var sayi in sayilar)
            {
                toplam += sayi;
            }
            //bir dizi(array) eleman sayısını bulmak için Count yöntemi kullanılır
            ortalama = toplam / sayilar.Count();
        }

        static void Main(string[] args)
        {
            double toplam;
            double ortalama;
            int[] dizi = new int[] { 1, 8, 7, 6, 5, 70, 55 };
            Outhesapla(dizi, out toplam, out ortalama);
            Console.WriteLine($"Sayıların Toplamı : {toplam}\nSayıların Ortalaması : {ortalama:N2}");


            //int sayi;
            //ekle(out sayi);
            //Console.WriteLine($"sayı değeri :{sayi}");
          //  --------------------------------
          /*  Console.WriteLine("sayı değeri :{0}",sayi);
            Console.WriteLine("sayı değeri :"+sayi);*/

            /*  sonuc = topla();
              sonuc = topla(12, 4);
              sonuc = topla(55, 68, 90, 100);*/
            //sonuc= hesapla('*', 8, 4, 2);
            // sonuc = hesapla('-', 8, 4, 2);

        }


        static int topla(params int[] sayilar)
        {
            int toplamaSonucu = 0;    ///    int < double
            if (sayilar.Length == 0)
                return 0;
            foreach (var sayi in sayilar)
            {
                toplamaSonucu += sayi;
            }
            return toplamaSonucu;
        }

        static int hesapla(char islemci, params int[] sayilar)
        {
            //değer döndüren metotlarda en az 1 tane return olması gerekir
            int toplam = 0;
            if (islemci == '+')
            {
                foreach (var sayi in sayilar)
                {
                    toplam += sayi;
                }
                return toplam;
            }
            else if (islemci == '*')
            {
                toplam = 1;
                foreach (var sayi in sayilar)
                {
                    toplam *= sayi;
                }
                return toplam;
            }
            else
                return 0;
        }
        static int sum(int x, int y)
        {
            return 1;
        }
        static int sum(int x, int y, int z)
        {
            return 1;
        }
    }
}
