using System;

namespace WhileDongusu
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //int sayi;
            //Console.WriteLine("Welcome.Please enter a number");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //int sayac = 1;
            //while (sayac <= sayi)
            //{

            //    Console.WriteLine(sayac);
            //    sayac++;
            //}


            //x ile 100000 arasindaki sayilari yazdir
            int sayi;
            Console.WriteLine("Please enter a number.");
            sayi = Convert.ToInt32(Console.ReadLine());
            while (sayi <= 10000)
            {
                Console.WriteLine(sayi);
                sayi++;
            }

        }
    }
}
