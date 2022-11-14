using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseExample5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Geçme notu hesaplama

            //öğrenci 1 vize ve 1 final sınavına giriyor.
            //vizenin %40'ı ve finalin %60'ı alınarak geçme notu hesaplanıyor.
            //60 ve üzeri ise geçer. 
            int vize, final;
            double ortalama=0;
            Console.WriteLine("vize notunuzu giriniz: ");
            vize=Convert.ToInt32(Console.ReadLine()); 
             Console.WriteLine("final notunuzu giriniz");
            final= Convert.ToInt32(Console.ReadLine());

            ortalama = vize * 40 / 100 + final * 60 / 100;
            if (ortalama >=60 )
            {
                Console.WriteLine("Geçti");
            }
            else
            {
                Console.WriteLine("kaldı");
            }
            Console.WriteLine("ortalamanız= {0}", ortalama);
            Console.ReadKey();  
        }
    }
}
