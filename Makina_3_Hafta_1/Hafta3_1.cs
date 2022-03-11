using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makina_3_Hafta_1
{
    class Hafta3_1
    {
        static void Main(string[] args)
        {
            double dbl = 478.952;
            float fl = 478.952f; //float değişkene Değer atamalarında F yada f son eki kullanılır. 
            decimal dc = 478.952M;//decimal değişkene Değer atamalarında M yada m son eki kullanılır. 
            Console.WriteLine(dc/2.5m); //decimallerle çalışırken başka bir değer kullanıyorsak o değerin sonuna da M yada m ekini kullanırız

            int x = 3;
            float y = 4.5f;
            int z = 5;
            // 3 * 4.5 / 5 = 2.7
            int sonuc = (int)(x * y / z);  //bilinçli tür dönüşümü
            Console.WriteLine("işlem sonucu : {0} ",sonuc);
            Console.WriteLine("{0} * {1} / {2} = {3:C2}",x, y, z, (x * y /z));
            //sayıları formatlı yazdırma
            dbl = 7845345.879513235741;
            Console.WriteLine("---------------------");
            Console.WriteLine("sayı : {0}",dbl);
            Console.WriteLine("sayı : {0:N6}", dbl);
            Console.WriteLine("sayı : {0:C3}", dbl);
            Console.WriteLine("sayı : {0:F2}", dbl);

            //---------------------------------------------
            float urunFiyatı = 850.99f;
            float indirimOranı = 0.20f;
            float indirimliFiyat = urunFiyatı * (1 - indirimOranı);
            Console.WriteLine("indirimli Ürün Fiyatı : {0:C2}",indirimliFiyat);
            Console.WriteLine("İndirimden sonraki fark : {0:C2}", urunFiyatı - indirimliFiyat);
            //yukarıdaki yazdırma işlemleri aşağıdaki gibi de yapılabilir
            Console.WriteLine($"İndirimli Ürün Fiyatı :{indirimliFiyat:C2}");
            Console.WriteLine($"İndirimden sonraki Fark :{urunFiyatı - indirimliFiyat:C2}");

            //ctrl + shift + B projeyi derler. 












        }
    }
}
