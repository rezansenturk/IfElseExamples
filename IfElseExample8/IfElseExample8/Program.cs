using System;

namespace IfElseExample8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Maaşı ve mesai saati girilen bir işçi var
            //mesai ücreti şu şekilde hesaplanır: saat başına 30TL
            //Eğer toplam 25 saat ve üzeri mesai yaparsa saat başına 40 tl alacak
            //işçinin toplam alacağı yeni maaş
            int maas, mesai,mesaiUcret=0;
            Console.WriteLine("maaşınızı giriniz");
            maas=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("mesai saati giriniz");
            mesai=Convert.ToInt32(Console.ReadLine());
           
            if (mesai>=25)
            {
                mesaiUcret = mesai * 40;
                maas = maas + mesaiUcret;
                Console.WriteLine("Toplam maaşınız : {0}",maas);
            }

            if (mesai<25)
            {
                mesaiUcret = mesai * 30;
                maas= maas + mesaiUcret;
                Console.WriteLine("Toplam maaşınız: {0}",maas);
            }
            Console.ReadLine();
        }
    }
}
