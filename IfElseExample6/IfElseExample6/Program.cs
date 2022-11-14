using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseExample6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //girilen hava sıcaklığına göre havanın durumunu gösteren program
            double derece;
            Console.WriteLine("hava sıcaklığını gir");
            derece =Convert.ToDouble(Console.ReadLine());
            if (derece < 15)
            {
                Console.WriteLine("hava soğuk");
            }
            if (derece >= 15 && derece<25)
            {
                Console.WriteLine("hava normal");
            }
            if (derece >= 25 && derece<40)
            {
                Console.WriteLine("hava sıcak");
            }
            if(derece >= 40)
            {
                Console.WriteLine("evden dışarı çıkmayınız");
            }
            Console.ReadKey();
        }
    }
}
