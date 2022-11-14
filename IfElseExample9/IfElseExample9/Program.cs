using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseExample9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //iki sayı giriliyor büyük olanı ekrana yazdır
            int sayi1;
            int sayi2;
            Console.WriteLine("1. sayıyı giriniz");
            sayi1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. sayıyı giriniz");
            sayi2= Convert.ToInt32(Console.ReadLine());
            if (sayi1 > sayi2)
            {
                Console.WriteLine($"büyük olan sayı: {sayi1}");
            }
            else
            {
                Console.WriteLine("büyük olan sayı: {0}",sayi2);
            }
            Console.ReadKey();
        }
    }
}
