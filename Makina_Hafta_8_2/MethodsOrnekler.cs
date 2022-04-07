using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makina_Hafta_8_2
{
    class MethodsOrnekler
    {
        //parametre almayan ve değer döndürmeyen metod
        static public void cemberAlani()
        {
            Console.WriteLine("Çemberin Yarıçapı Nedir?");
            double yariCap = double.Parse(Console.ReadLine());
            double alan = 0;
            alan = Math.PI * yariCap * yariCap;
            Console.WriteLine($"Çemberin Alanı : {alan:N4}");
        }

        //parametre alan ve değer döndürmeyen metod
        void toplama(int s1, int s2)
        {
            //Console.WriteLine($"{s1} ve {s2} sayıların toplamı : {s1+s2}");
            Console.WriteLine($"{s1} + {s2} = {s1 + s2}");
        }
        
        void toplama(int[] sayilar)
        {
            int toplam = 0;
            foreach (var item in sayilar)
            {
                //toplam = toplam + item;
                toplam += item;
            }
            Console.WriteLine(toplam);
        }
        static void ortalama(int[] sayilar)
        {
            double ortalama = 0;
            double toplam = 0;
            foreach (var item in sayilar)
            {
                toplam += item;
            }
            ortalama = toplam / (sayilar.Length);
            Console.WriteLine($"Sayıların Ortalaması : {ortalama:N3}");
        }


        static void Main(string[] args)
        {
             cemberAlani();

            //static olmayan metodlara erişim için o metodun bir başvurusunu oluşturmak gerekir
            MethodsOrnekler m = new MethodsOrnekler();
             m.toplama(18, 68);
            m.toplama(15, 89); 
            int[] sayilar = new int[] { 5, 6, 9, 45, 87, 96 };
            // m.toplama(sayilar);
            double[] rakamlar = new double[] { 4.5, 890.78, 100 };
            ortalama(sayilar);
             
            
        }
    }
}
