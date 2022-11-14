using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseExmple4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir kişi mağazadan
            //100 TL ve üzeri alışveriş yaparsa %10 indirim,
            //200 TL ve üzeri alışveriş yaparsa %15 indirim,
            //300 TL ve üzeri alışveriş yaparsa %20 indirim
            //kazandığını ve ödeyeceği miktarı ekrana yazan C # kodlarını yazınız.
            int alisverisTutari;
            double odenecekMiktar=0;

            Console.WriteLine("****100TL ve üzeri  alışverişinizde %10 / 200 TL ve üzeri %15 / 300 TL ve üzeri %20 indirim****");

            Console.WriteLine("Alışveriş Tutarını Giriniz: ");
            alisverisTutari = Convert.ToInt32(Console.ReadLine());
            if (alisverisTutari >=100 && alisverisTutari < 200)
            {
                odenecekMiktar = alisverisTutari - alisverisTutari * 10 / 100;
                Console.WriteLine("%10 indirim kazandınız ve alışveriş tutarınız: {0}",odenecekMiktar);
            }
            if (alisverisTutari >= 200 && alisverisTutari < 300)
            {
                odenecekMiktar = alisverisTutari - alisverisTutari * 15 / 100;
                Console.WriteLine("%15 indirim kazandınız ve alışveriş tutarınız: {0}", odenecekMiktar);
            }
            if (alisverisTutari >= 300)
            {
                odenecekMiktar = alisverisTutari - alisverisTutari * 20 / 100;
                Console.WriteLine("%20 indirim kazandınız ve alışveriş tutarınız: {0}", odenecekMiktar);
            }
            else if(alisverisTutari<100)
            {
                Console.WriteLine("Alışveriş tutarı: {0}", alisverisTutari);
            }
            Console.ReadLine();
        }
    }
}
