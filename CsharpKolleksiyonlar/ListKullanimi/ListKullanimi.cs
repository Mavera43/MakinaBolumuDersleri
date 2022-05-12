using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListKullanimi
{
    class ListKullanimi
    {
        static void Main(string[] args)
        {

            List<string> ulkeler = new List<string>() 
            { "Türkiye", 
               "Almanya", 
               "Fransa", 
               "Pakistan" 
            };

            List<string> sehirler = new List<string>();
            Console.WriteLine($"kapasitesi :{sehirler.Capacity}");
            Console.WriteLine($"Eleman sayısı :{sehirler.Count}");
            //list ögesine eleman ekleme (add metodu ile)
            sehirler.Add("Kütahya");
            Console.WriteLine($"kapasitesi :{sehirler.Capacity}");
            Console.WriteLine($"Eleman sayısı :{sehirler.Count}");
            sehirler.Add("Afyon");
            sehirler.Add("İzmir");
            sehirler.Add("İstanbul");
            sehirler.Add("Ankara");
            Console.WriteLine($"kapasitesi :{sehirler.Capacity}");
            Console.WriteLine($"Eleman sayısı :{sehirler.Count}");
            Console.WriteLine($"4.eleman : {sehirler[3]}");

            sehirler.AddRange(new string[] { "Bursa", "Kocaeli", "Balıkesir" });
            int i = 0;
            foreach (var item in sehirler)
            {
                Console.WriteLine($"{i++}.{item}");
            }
            i = 0;
            sehirler.Insert(0, "Adana");
            Console.WriteLine("insert işleminden sonra");
            foreach (var item in sehirler)
            {
                Console.WriteLine($"{i++}.{item}");
            }
            //aram işlemleri IndexOf
            int index = sehirler.IndexOf("Bursa");
            if(index>=0)
                Console.WriteLine($"Aranan şehir var indexi :{index} \t{sehirler[index]}");
            else
                Console.WriteLine("Aranan şehir yok");
            //belirtilen değeri siler
            sehirler.Remove("Adana");
            //belirtilen indexteki değeri siler
            sehirler.RemoveAt(3);
            //belirtilen indisten itibaren belirtilen kadar elemanı siler
            sehirler.RemoveRange(3, 4);
            //tüm elemanları silecek.
            sehirler.Clear();
        }
    }
}
