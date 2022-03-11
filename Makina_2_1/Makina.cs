using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makina_2_Hafta_Ders1
{
    class Makina
    {
        //c# nesne yönelik programlama olduğundan herşey bir clas içinde yer almalıdrı.
        static void Main(string[] args)
        {

            //Console.WriteLine("Merhaba Makina Bölümü");
            //Console.WriteLine("Kütahya Dumlupınar Üniversitesi");
            //Console.WriteLine("Mühendislik Fakültesi");
        //------------------------------
            //değişken tanımlama
            string mesaj;
            //ilk değeri verilmemiş bir değişken kullanılırsa hata oluşur
            //bir değişkene değer atama
            mesaj = "Değişkenleri kullanmak için lütfen değer atayın";
            mesaj = "";//değişkenin içini boşaltır
            mesaj = null; //null hiçbirşey demektir.
            Console.WriteLine(mesaj);
            //------------------------------
            //bir değişken tipinin maximum ve minumum değerini bulmak için "MinValue" ve "MaxValue" metodları kullanılır. :N simgesi sayıların binlik ayraçlı bir şekilde gösterilmesini sağlar
            //Console.WriteLine("int tipinin en küçük değeri {0:N}", int.MinValue);
            //Console.WriteLine("int tipinin en büyük değeri {0:N}",int.MaxValue);
            //Console.WriteLine("fark :{0}",202013121001-int.MaxValue);
            //----------------------
            long ogrno = 202013121001; //long tipi tamsayı tipidir
            string adSoyad = "İSMAİL CEM"; //string metin(yazı) veri tipidir
            double gno = 3.2;
            // 202013121001 nolu İSMAİL CEM'in genel not ortalaması : 3.2'dir. 

            //Console.WriteLine("Öğrencinin numarası :"+ogrno);
            //Console.WriteLine("Öğrencinin numarası :{0}",ogrno);

            //Console.WriteLine($"Öğrencinin numarası :{ogrno}");

            //Console.WriteLine($"{ogrno} nolu {adSoyad}'in genel not ortalaması : {gno}'dir.");
            //----------------
            int x = 20;
            int y = 25;
            int toplam = x + y;
            // bir değişkenin veri tipini öğrenmek için GetType() metodu kullanılır
           // Console.WriteLine(toplam.GetType());
            //Console.WriteLine($"{x} + {y} = {toplam}");
            //Console.WriteLine($"{x} + {y} = {x + y}");
            //Console.WriteLine("x ve y'nin toplamı :" + (x + y));
            //sayısal verileri yazdırırken 1000'lik ayracı kullanmak N parametresini kullanırız
            double maas = 9250.796;
            float ucret = 12570.48f;
            decimal odeme = 1254547.7898701M;
            //Console.WriteLine($"Ödenecek Ücret : {ucret:N1}");
            //Console.WriteLine($"Yapılacak ödeme : {odeme:N3}");
            //Console.WriteLine($"Ödenecek Maaş : {maas:N2}");
            //Console.WriteLine($"Ödenecek Ücret : {ucret:C1}");
            //Console.WriteLine($"Yapılacak ödeme : {odeme:C3}");
            //Console.WriteLine($"Ödenecek Maaş : {maas:C2}");
//------------------------------
            //Mantıksal veri tipleri
            int x1 = 20;
            int x2 = 25;
            int t = 100;
            bool b1 = true;
            bool b2 = 10 > 8;
            bool b3 = (10 * 5 >= 20 * 3);
            // veya sembolu ||    alt gr+z tuşunun solundaki tuşa birlikte basılır
            // ve   sembolu &&  shift + 6 tuşlarına birlikte basılır
            // eşitlik sembolu == (iki tane eşit simgesi)
            bool b4 = (x1 == x2) || (x1 * x2 > t);
           //   \n satır atlatır
            //Console.WriteLine("b1 : " + b1);
            //Console.WriteLine("b2 : " + b2);
            //Console.WriteLine("b3 : " + b3);
            //Console.WriteLine("b4 : " + b4);
           // yukarıdaki 4 satır yerine aşağıdaki gibi de yazabiliriz
           // Console.WriteLine($"b1 : {b1}\nb2 : {b2}\nb3 : {b3}\nb4 : {b4}");
            //  --------------------------------
            //   Console.ReadLine() kullanımı........Console.ReadLine();//enter tuşu basılana kadar bekler

            string AdSoyad;
            string Bolum;
            Console.WriteLine("Ad Soyad Giriniz :");
            AdSoyad = Console.ReadLine();
            Console.WriteLine("Bölümünüzü Giriniz :");
            Bolum = Console.ReadLine();

            Console.WriteLine("Girdiğiniz Değerler :");
            Console.WriteLine($"Ad Soyad : {AdSoyad}");
            Console.WriteLine($"Bölümünüz : {Bolum}");
            Console.ReadLine();
        }

    }
}
