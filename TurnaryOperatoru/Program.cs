using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnaryOperatoru
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Bir Sayı Giriniz");
            int sayi = int.Parse(Console.ReadLine());

            int sonuc = sayi < 3 ? sayi * 5 : sayi > 3 && sayi < 9 ? sayi * 3 :
                sayi >= 9 && sayi % 2 == 0 ? sayi * 10 : sayi % 2 == 1 ? sayi : -1;
            Console.WriteLine(sonuc);
            

        }
    }
}
