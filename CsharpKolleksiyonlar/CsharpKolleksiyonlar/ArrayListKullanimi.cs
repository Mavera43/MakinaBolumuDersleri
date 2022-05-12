using System;
using System.Collections;

namespace ArraylistKullanimi
{
    class ArrayListKullanimi
    {
        static void Main(string[] args)
        {
            try
            {
                ArrayList ogrenci = new ArrayList();
                //arrayliste eleman eklemek için Add metodunu kullanacağız
                ogrenci.Add(202012121001);
                ogrenci.Add("Şenol Demirci");
                ogrenci.Add("Bölümü");
                ogrenci.Add(true);
                ogrenci.Add(3.22);
                ogrenci.Add(null);
                //arraylistin belirli bir indexindeki elemanına erişim
                Console.WriteLine(ogrenci[1]);
                Console.WriteLine("Eleman sayısı :" + ogrenci.Count);
                Console.WriteLine("Kapasite : " + ogrenci.Capacity);

                ogrenci.Add("Mühendislik Fakültesi");
                ogrenci.Add("Merkez Kampüs");

                Console.WriteLine("Eleman sayısı :" + ogrenci.Count);
                Console.WriteLine("Kapasite : " + ogrenci.Capacity);
                Console.WriteLine("------------");
                ogrenci.Add("Evliya Çelebi Yerleşkesi");
                Console.WriteLine("Eleman sayısı :" + ogrenci.Count);
                Console.WriteLine("Kapasite : " + ogrenci.Capacity);
                //arraylist'in tüm elemanlarına erişmek için foreach döngüsü yada for döngüsü kullanırız
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Arraylis elemanları");
                foreach (var item in ogrenci)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("\n\n");
                //for döngüsü ile
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("for döngüsü ile");
                for (int i = 0; i < ogrenci.Count; i++)
                {
                    Console.WriteLine(ogrenci[i]);
                }
                //arama işlemleri
                //contains metodu ile arama yapmak--değere göre arama yapar
                bool sonuc = ogrenci.Contains("Şenol");
                if(sonuc)
                    Console.WriteLine("Aranan eleman mevcut");
                else
                    Console.WriteLine("Aranan eleman yok!");

                //IndexOf yöntemi ile arama yapmak--index numarasını döndürür
                int index = ogrenci.IndexOf("Bölümü");
                if(index>=0)
                    Console.WriteLine("Aranan eleman mevcut : "+ogrenci[index]);
                else
                    Console.WriteLine("Aranan eleman yok!");

                //değere göre arraylist'ten eleman silmek
                ogrenci.Remove("Merkez Kampüs");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("for döngüsü ile");
                for (int i = 0; i < ogrenci.Count; i++)
                {
                    Console.WriteLine(i + ". eleman:   " + ogrenci[i]);
                }

                //indis numarasına göre arraylist'ten eleman silmek
                 ogrenci.RemoveAt(0);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(ogrenci[0]);
                //indis numarasına göre birden fazla arraylist'ten eleman silmek
                ogrenci.RemoveRange(2, 2);
                Console.WriteLine("removeRange ile silme işleminden sonra");
                for (int i = 0; i < ogrenci.Count; i++)
                {
                    Console.WriteLine(i + ". eleman:   " + ogrenci[i]);
                }
                //tüm elemanları silmek için...
                ogrenci.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(ogrenci.Count);
                Console.WriteLine(ogrenci.Capacity);
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
