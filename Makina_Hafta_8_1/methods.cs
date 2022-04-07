using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makina_Hafta_8_1
{
    class methods
    {
        //çemberin alanını hesaplayan method/fonksiyon/yöntem yazalım. Bu metod bize alanı geri döndürsün

        //parametre almayan ve geri değer döndürmeyen methot tipi
        void cemberAlaniHesapla()
        {
            Console.WriteLine("İki değerin toplamı : " + (10+25));
            //kod bloğu
        }

        //parametre alan fakat geri değer döndürmeyen methot tipi
        void cemberAlaniHesapla(double yariCap)
        {

        }
        public double cemberAlaniHesapla(double yariCap, double pi)
        {
            return 0;
        }
        //derleyici, parametreleri ve sayıları birbirinden farklı olmak koşulu ile aynı metod isimlerine izin verir.
        //parametre almayan fakat geri değer döndüren methot tipi
        double cemberAlaniHesapla2()
        {
            return 0;
        }

        static void Main(string[] args) //başlatıcı metod.
        {

        }
    }
}
