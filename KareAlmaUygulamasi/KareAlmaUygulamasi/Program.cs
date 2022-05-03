using System;

namespace KareAlmaUygulamasi
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //1- Kullanicinin yazdigi sayinin karesini alan bir uygulama yaz

            int sayi;
            Console.WriteLine("Hi! Please enter a number.");
            string girdi = Console.ReadLine();
            sayi = Convert.ToInt32(girdi);
            Console.WriteLine(sayi * sayi);
            
            
        }


    }
    }
