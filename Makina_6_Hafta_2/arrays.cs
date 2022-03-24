using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makina_6_Hafta_2
{
    class arrays
    {
        static void Main(string[] args)
        {
            //bir değişkende birden fazla değer saklama yöntemidir
            int i = 0;
            int[] sayilar;
            int[] sayilar2 = new int[5];
            int[] sayilar3 = { 10, 20, 30, 40 }; //diziyi tanımlarken değerlerinide atamış olduk
            int[] sayilar4 = new int[6] { 1, 2, 3, 4, 5 ,6};

            string[] mevsimler = new string[4];

            //dizi değişkenine değer atama
            mevsimler[0]= "İlkbahar";
            mevsimler[1]= "Yaz";
            mevsimler[2]= "Sonbahar";
            mevsimler[3]= "Kış";
            //mevsimler[4]= "bilinmeyen";// bu satırda IndexOutOfRangeException: Dizin, dizi sınırlarının dışındaydı. hatasını alırsınız. Çünkü 4. indis dizi boyutunu aşıyor.

            Console.WriteLine(mevsimler[2]);
            
            char c = 'c';

            char[] sesliHarfler = new char[8] { 'a','e', 'ı','i','o','ö','u','ü' };
            char[] sesliHarfler1 =new char[8];
            sesliHarfler1[0] = 'a';
            sesliHarfler1[5] = 'ö';
            sesliHarfler1[3] = 'e';

            int[] i2 = new int[3] { 1, 2, 3 };

            Console.WriteLine("4.sesli harf: "+sesliHarfler1[4]);


            //int s =  sesliHarfler1.Length;
            //  i = 0;
            // Console.WriteLine("sesli harfler");
            // for ( i = 0; i < sesliHarfler.Length; i++)
            // {
            //     Console.WriteLine(sesliHarfler[i]);
            // }

            // Console.WriteLine("sesli harfler tersten yazım");
            // for (i = sesliHarfler.Length-1; i >= 0; i--)
            // {
            //     Console.WriteLine(sesliHarfler[i]);
            // }

            //dizilerde kullanılan foreach döngüsü var. //dizideki eleman sayısı önceden bilinmediği durumlarda kullanılan döngü çeşididir.

            //foreach (char item in sesliHarfler)
            //{
            //    Console.WriteLine(item);
            //}

            // 10 elemanlı dizi tanımlayıp bu dizinin elemanlarına rastgele sayı ekleyen ve bunu ekrana yazdıran c# kodları
            int[] rakamlar = new int[10];

            Random r = new Random();
            for (int j = 0; j < 10; j++)
            {
                rakamlar[j] = r.Next(1, 100);
            }
            int toplam = 0;
            foreach (var item in rakamlar)
            {
                toplam += item;
                Console.WriteLine(item);
            }
            Console.WriteLine($"rakamların toplamı{toplam}");


        }
    }
}
