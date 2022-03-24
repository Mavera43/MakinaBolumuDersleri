using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makina_6_Hafta_1
{
    class fordongusuvetarihmetodu
    {
        static void Main(string[] args)
        {
            // döngüler for
            // bazı tarih metodları kullanıcağız formatlı metin oluşturma kavramı 
            // başlangıç ve bitiş tarihleri arasındaki çalışma günleri sayısını
            // bulacak ve günlük yevmiye ücreti ile çarparak toplam ödecek tutarı bulacak
            DateTime dateTime = DateTime.Now;
            DateTime startDate;
            DateTime endDate;
            double ucret;
            int calistigiGunSaysisi = 0;
            double odenecekUcret = 0;
            Console.WriteLine("İşe başlama tarihin giriniz");
            startDate= Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("İş bitim tarihi giriniz");
            endDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Yevmiye ücreti Nedir?");
            ucret = Convert.ToDouble(Console.ReadLine());
            int toplam = 0;
            string str = "";

            for (DateTime date=startDate ; date < endDate; date=date.AddDays(1))
            {
                if(date.DayOfWeek==DayOfWeek.Saturday || date.DayOfWeek==DayOfWeek.Sunday)
                {
                    odenecekUcret += 0; //odenecekUcret = odenecekUcret + 0;
                    str += string.Format("{0,-30}|{1,10:C2}\n", date.ToString("dd/M/yyyy dddd"), odenecekUcret);
                   // Console.WriteLine(date.ToString("dd/M/yyyy dddd")+"\t"+ odenecekUcret);
                    //    \t tab tuşu yerine geçer  \n ise enter yerine geçer
                }
                else
                {
                    calistigiGunSaysisi++;  //calistigiGunSaysisi = calistigiGunSaysisi+1;
                    odenecekUcret += ucret;
                    str += string.Format("{0,-30}|{1,10:C2}\n", date.ToString("dd/M/yyyy dddd"), odenecekUcret);
                    //Console.WriteLine(date.ToString("dd/M/yyyy dddd") + "\t" + odenecekUcret);
                }
            }
            Console.WriteLine(str);
            Console.WriteLine($"Toplam ödenecek ücret : {odenecekUcret}\nÇalıştığı gün sayısı : {calistigiGunSaysisi}");
            TimeSpan fark = endDate.Subtract(startDate);
            Console.WriteLine($"İki tarih arasındaki gün farkı : {fark.TotalDays}");


        }
    }
}
