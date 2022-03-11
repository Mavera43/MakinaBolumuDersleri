using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makina_3_Hafta_2
{
    class turDonusumleri
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tür dönüşümleri");
            Console.WriteLine("---------------");
            Console.WriteLine("Bilinçsiz tür dönüşümü/küçük türün büyük türe dönüştürülmesi");
            byte b1 = 45;
            int i = b1;
            i = 78;
            // b = 257; //taşma hatası meydana gelir.
            float f = 125.3f;
            double d = f;
            //f = d; hata oluşur. büyük tür küçük türe dönüştürülmeye çalışılıyor

            byte b2 = 9;
            Console.WriteLine("İşlem tipi : {0}",(b1 + b2).GetType());
            // byte sonuc = b1 + b2;
            //byte, sbyte, short ve ushort türündeki değişkenlerle yapılan matematiksel işlemler int türüne dönüşür.
            int sonuc = b1 + b2;
            //başvuru numarası 0 ile 255 arasında olacaksa ve eminsek,
            int basvuruNo = 255;
            byte b3 = (byte)basvuruNo;
            Console.WriteLine($"başvuruNo değişkenin içeriği : {basvuruNo}");
            Console.WriteLine($"b3 değişkenin içeriği : {b3}");
            Console.WriteLine("------------------");
            basvuruNo = 550;
            b3 = (byte)basvuruNo;  //veri kaybı yaşanır. Bilinçli tür dönüşümü yaptık
            Console.WriteLine($"başvuruNo değişkenin içeriği : {basvuruNo}");
            Console.WriteLine($"b3 değişkenin içeriği : {b3}");
            Console.WriteLine("------------------");
            Console.WriteLine("To.String() Metodu / sayıları stringe dönüştürür");
            Console.WriteLine("bir sayı giriniz...");
            string s = Console.ReadLine();
            int s1 = int.Parse(s);
            int x1 = s1 + 10;

            string str = s1.ToString() + x1.ToString();
            Console.WriteLine($"str değişkeninin sonucu : {str}");
            Console.WriteLine("----------------------");
            float sayı = 3 * (5f / 7);
            Console.WriteLine($"sayı değişkeninin değeri :{sayı}");



        }
    }
}
