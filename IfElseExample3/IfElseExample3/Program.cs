using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir öğrencinin üç sınav notuna göre ortalaması hesaplanarak notu 50 ve üzeri ise geçti, 50 nin altındaysa kaldı yazan C# kodlarını yazınız.
            int sinavNot1,sinavNot2,sinavNot3;
            double ortalama;
            sinavNot1Tekrar: Console.WriteLine("1. sınav notunuzu giriniz");
            sinavNot1 = Convert.ToInt32(Console.ReadLine());
            if (sinavNot1 > 100 || sinavNot1 < 0)
            {
                Console.WriteLine("Sınav notu geçersizdir lütfen yeni bir sınav notu giriniz");
                goto sinavNot1Tekrar;
            }

            sinavNot2Tekrar: Console.WriteLine("2. sınav notunuzu giriniz");
            sinavNot2 = Convert.ToInt32(Console.ReadLine());
            if (sinavNot2 > 100 || sinavNot2 < 0)
            {
                Console.WriteLine("Sınav notu geçersizdir lütfen yeni bir sınav notu giriniz");
                goto sinavNot2Tekrar;
            }
            sinavNot3Tekrar: Console.WriteLine("3. sınav notunuzu giriniz");
            sinavNot3 = Convert.ToInt32(Console.ReadLine());
            if (sinavNot3 > 100 || sinavNot3 < 0)
            {
                Console.WriteLine("Sınav notu geçersizdir lütfen yeni bir sınav notu giriniz");
                goto sinavNot3Tekrar;
            }
            ortalama = (sinavNot1 + sinavNot2 + sinavNot3) / 3;
            if (ortalama <= 30)
            {
                Console.WriteLine("Not Ortalaması: FF");
            }
            if (ortalama >= 31 && ortalama < 41)
            {
                Console.WriteLine("Not Ortalaması: DD");
            }
            if (ortalama >= 41 && ortalama < 50)
            {
                Console.WriteLine("Not Ortalaması: DC");
            }
            if (ortalama >= 50 && ortalama < 61)
            {
                Console.WriteLine("Not Ortalaması: CC");
            }
            if (ortalama >= 61 && ortalama < 71)
            {
                Console.WriteLine("Not Ortalaması: CB");
            }
            if (ortalama >= 71 && ortalama <81)
            {
                Console.WriteLine("Not Ortalaması: BB");
            }
            if (ortalama >= 81 && ortalama <91)
            {
                Console.WriteLine("Not Ortalaması: BA");
            }
            if (ortalama >= 91 && ortalama <= 100)
            {
                Console.WriteLine("Not Ortalaması: AA");
            }
            if (ortalama >= 50)
            {
                Console.WriteLine("Geçti. Ortalama: {0}", ortalama);
            }
            if (ortalama < 50)
            {
                Console.WriteLine("Kaldı. Ortalama: {0}", ortalama);
            }
            Console.ReadKey();
        }
    }
}
