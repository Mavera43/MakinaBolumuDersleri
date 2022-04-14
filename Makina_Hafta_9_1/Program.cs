using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makina_Hafta_9_1
{
    class Program
    {
       public int makina = 10;
       private string dpu = "Kütahya Dumlupınar Üniversitesi";
        // bool tipli değişkenlerin varsayılan değeri false'dur.
       bool intvalesitmi(int val1, int val2)
        {
            /*
            if (val1.Equals(val2))
                return true;
            else
                return false;*/

            bool retval;
            /* if (val1.Equals(val2))
                 retval = true;
             else
                 retval = false;*/
            //ternary operatörü //üçlü operatör
            retval = (val1.Equals(val2)) ? true : false;
            retval = (val1.Equals(val2));
            return retval;

        }
        private static void esitmiMetodu()
        {
            Program prg = new Program();
            bool sonuc = prg.intvalesitmi(12, 12);
            if (sonuc)
                Console.WriteLine("Sayılar eşit");
            else
                Console.WriteLine("Sayılar farklı");
        }
        private static bool doublevalesitmi(double val1, double val2)
        {
            if (val1.Equals(val2))
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.intvalesitmi(4, 8);
            p.makina = 20;
            p.makina = 30;
            p.dpu = "Makina Mühendisliği";

            p.intvalesitmi(1, 2);
            bool sonuc= doublevalesitmi(98.9, 98.9);
            Console.WriteLine(doublevalesitmi(98.9, 98.9));
            if(doublevalesitmi(1.1,1.2))
            {

            }
            else
            {

            }
            // intvalesitmi(10.5, 98.9);
            //esitmiMetodu();

        }

      

        // seçili olan satırları metoda dönüştürür.  CRTL + R + M 
        
    }
}
