using System;

namespace TasarrufUygulamasi
{
    class MainClass
    {
        public static void Main(string[] args)
        {
          

 
            //3- Tasarruf Hesaplayici
            //Kaç ampul var? Günde ne kadar çalışıyor?
            //Normal ampul saatte 2TL
            //Tasarruflu ampul %20 daha ucuz


            int sayi1;
            int sayi2;
            Console.WriteLine("Please enter how many light bulbs do you have in your house.");
            string ampulsayisi = Console.ReadLine();
            Console.WriteLine("How many hours they stay on?");
            string saatsayisi = Console.ReadLine();
            sayi1 = Convert.ToInt32(ampulsayisi);
            sayi2 = Convert.ToInt32(saatsayisi);
            Console.WriteLine("It costs " + sayi1 * sayi2 + " Dollars per day with normal light bulbs");
            Console.WriteLine("It costs " + sayi1 * sayi2 * 0.8 + " Dollars per day thrifty bulbs");

        }
    }
}
