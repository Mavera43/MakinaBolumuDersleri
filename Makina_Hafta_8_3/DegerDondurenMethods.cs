using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makina_Hafta_8_3
{
    class DegerDondurenMethods
    {
        //gelen 2 sayıyı ve gelen matematik operatöre göre işlem yapan ve sonucu geri gönderen medot.

        static double Hesapla(double sayi1, double sayi2, char islemci)
        {
            double sonuc = 0;
            if (islemci == '+')
                sonuc = sayi1 + sayi2;
            else if (islemci == '-')
                sonuc = sayi1 - sayi2;
            else if (islemci == '/')
            {
                if (sayi2 == 0)
                { Console.WriteLine("Sayı1 sıfıra bölünemez...");
                    return 0;
                }
                else
                    sonuc = sayi1 / sayi2;
            }
               
            else
                sonuc = sayi2 * sayi1;
            return sonuc;
        }
        static double Calculate(double sayi1, double sayi2, char islemci)
        {
            double sonuc = 0;
            switch (islemci)
            {
                case '+': sonuc = sayi2 + sayi1; break;
                case '-': sonuc = sayi2 - sayi1; break;
                case '/': sonuc = sayi1 / sayi2; break;
                case '*': sonuc = sayi1 * sayi2; break;
                default: Console.WriteLine("Geçersiz matematik işlemci girildi");break;
            }

            return sonuc;
        }
        static void Main(string[] args)
        {
            //retval = dönen değer için kullacağımız değişken adı
            double retval = Hesapla(800, 0,'/');
             retval = Calculate(700, 0, '%');
            Console.WriteLine($"İşlem sonucu :{retval:N2}");
        }
    }
}
