using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseExample11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //mevsim giriniz
            //girilen mevsime göre  aylar ekrana yazılsın
            string mevsim;
            Console.WriteLine("Bir Mevsim Giriniz");
            mevsim = Console.ReadLine();
            mevsim=mevsim.ToUpper();

            if (mevsim == "KIŞ")
            {
                Console.WriteLine(mevsim +": Kasım,Aralık,Ocak,Şubat,Mart,Nisan");
            }
             if(mevsim == "İLKBAHAR")
             {
               Console.WriteLine(mevsim +": Mayıs,Haziran");
             }
            if(mevsim == "YAZ")
            {
                Console.WriteLine(mevsim + ": Temmuz,Ağustos");
            }
            if(mevsim == "SONBAHAR")
            {
                Console.WriteLine(mevsim + ": Eylül,Ekim");
            }
            Console.ReadKey();
        }
    }
}
