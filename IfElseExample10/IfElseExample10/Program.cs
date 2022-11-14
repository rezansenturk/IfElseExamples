using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseExample10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ekmek tarifi

            //1000 gram un için 650 gram su, 12 gram tuz, 5 gram maya gerekiyor eğer hava derecesi 25 den yukarı ise maya 2 gram olur
            //Kullanıcının gireceği un miktarına göre ekmek için gerekli tarifi veriniz.
            double maya, derece, tuz, su, un = 0;
            Console.WriteLine("Lütfen tarifini almak istediğiniz un gramını giriniz: ");
            un=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen hava derecesini giriniz.");
            derece=Convert.ToInt32(Console.ReadLine());
            
            if (derece>25)
            {
                su = un * 650 / 1000;
                tuz = un * 12 / 1000;
                maya = un * 2 / 1000;
                Console.WriteLine("Tarif: ");
                Console.WriteLine("un miktarı: " + un +"gr");
                Console.WriteLine("su miktarı: " + su + "gr");
                Console.WriteLine("tuz miktarı: " + tuz + "gr");
                Console.WriteLine("maya miktarı: " + maya + "gr");
            }
            else
            {
                su = un * 650 / 1000;
                tuz = un * 12 / 1000;
                maya = un * 5 / 1000;
                Console.WriteLine("un miktarı: " + un + "gr");
                Console.WriteLine("su miktarı: " + su + "gr");
                Console.WriteLine("tuz miktarı: " + tuz + "gr");
                Console.WriteLine("maya miktarı: " + maya + "gr");
            }
            Console.ReadKey();           
        }
    }
}
