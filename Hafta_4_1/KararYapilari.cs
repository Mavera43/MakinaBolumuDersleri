using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_4_1
{
    class KararYapilari
    {
        static void Main(string[] args)
        {
            ternaryKullanımı();


            // ifelse4();
            // ifelse3();
            // ifelse2();
            // ifelse1();
        }

        private static void ternaryKullanımı()
        {
            int sayı = 5 + 1;
            //ternary operatörü kullanımı. tek satırlık if else yapısı.

            //tek bir satırda kullanılabilir
            Console.WriteLine((sayı % 2 == 0) ? "Sayı Çift" : "Sayı Tek");

            //aşağıdaki şekilde de kullanılabilir.
            //  string sonuc = (sayı % 2==0) ?"Sayı Çift":"Sayı Tek" ;
            //  Console.WriteLine(sonuc);


            // yukarıdaki ternary yapısının if else ile çözümü
            //if (sayı % 2 == 0)
            //    sonuc = "Sayı Çift";
            //else
            //    sonuc = "Sayı Tek";
        }

        private static void ifelse4()
        {
            double gelir = 7000, vergiKesintisi = 0, netGelir = 0; //hesaplanacak

            if (gelir <= 5000)
                vergiKesintisi = gelir * .25;
            // 5000 ile 8000 arassındaysa
            else if (gelir <= 8000)
                vergiKesintisi = gelir * .30;
            // 8000 ile 12000 arasındaysa
            else if (gelir <= 12000)
                vergiKesintisi = gelir * .35;
            //12000 den büyükse
            else
                vergiKesintisi = gelir * .40;

            netGelir = gelir - vergiKesintisi;
            Console.WriteLine($"Kesinti Tutarı :{vergiKesintisi}\nNet Gelir :{netGelir}");
        }

        private static void ifelse3()
        {
            //Öğrencinin vize ve final notunu klavyeden aldıktan sonra ortalamasını hesaplayıp,
            //Daha sonra; Final notu 50 ve üzeri ise ve ortalaması 60’ın üzerinde ise GEÇTİ,
            //değilse KALDI yazacak bir C# programı.
            //Parse metodu string değişken yada ifadeleri sayıya dönüştürür.(int, double, float vs..)
            float vize = 0, final = 0, ortalama = 0;
            Console.WriteLine("Vize Notunu Giriniz");
            vize = float.Parse(Console.ReadLine());
            Console.WriteLine("Final Notunu Giriniz");
            final = float.Parse(Console.ReadLine());
            ortalama = vize * .40f + final * .60f;

            Console.WriteLine($"Sınav Ortalamanız : {ortalama}");
            if (ortalama >= 60 && final >= 50)
                Console.WriteLine("Geçtiniz");
            else
                Console.WriteLine("!!!!!Kaldınız!!!!!");
        }

        private static void ifelse2()
        {
            //bloklu if else yapısı
            //gno >=3 olanlara +4 kredi  ve harç tutarı %50 indirim
            //değilse +2 kredi harç tutarı değişmeyecek.
            float gno = 1.1f;
            int kredi = 24;
            float harcTutari = 450;

            if (gno >= 3)//true ise aşağıdaki kodlar çalışır(else kadar)
            {
                kredi += 4;
                harcTutari /= 2;
                Console.WriteLine($"Krediniz Artırıldı. Yeni krediniz : {kredi}");
            }
            //if deki mantıksal sınama false olurs çalışır
            //kredi 3'ten küçük ama 2'den de küçük olanlara kredi artırımı olmasın
            else
            { //nested if else
                if (gno >= 2 && gno < 3)//&& gno < 3 bu ifadeye gerek yok. çünkü if bloğunda 3'ten küçük olduğu belli oldu. tekrar 3'ten küçük mü diye sormaya gerek yok.
                {
                    kredi += 2;
                    Console.WriteLine($"Krediniz Artırıldı. Yeni krediniz : {kredi}");
                }
                else
                {
                    Console.WriteLine("Ortalamanız 2'nin altında olduğundan kredi artırımı yapılmadı...");
                    Console.WriteLine($"Krediniz  : {kredi}");

                }

            }
            Console.WriteLine($"Harç Tutarınız : {harcTutari}");
        }

        private static void ifelse1()
        {
            double gno = 2.5;
            bool sonuc = gno > 3;
            //float ve decimal değerler değişkene aktarılırken f yada m ekleri kullanılır.
            // mantıksal ifade = 12 > 8;
            //mantıksal sonuç = true yada false
            if (gno > 3)//20 satıra true olursa girer
                Console.WriteLine("Başarılısınız");
            else
                Console.WriteLine("Başarılı değilsiniz");
            Console.WriteLine("Karşılaştırma işlemi bitti..");
        }
    }
}
