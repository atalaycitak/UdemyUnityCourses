using System;

namespace TekCiftUygulamasi
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hi! Please enter a number.");
            int sayi = Convert.ToInt32(Console.ReadLine());
            bool ciftmi;

            if (sayi %2 == 0)

            {
                ciftmi = true;


            }
            else
            {
                ciftmi = false;
            }
            if (ciftmi)
            {
                Console.WriteLine("It is an even number!");
            }

            else
            {
                Console.WriteLine("It is an odd number!");
            }
        }

    }
}
