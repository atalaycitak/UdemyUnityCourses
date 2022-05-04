using System;

namespace KareAlveyaTekCift
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("Lütfen bir sayi giriniz");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi<10)
            {

                if (sayi % 2 == 0)
                {
                    Console.WriteLine("Sayi çift.");
                }

                else
                {
                    Console.WriteLine("Sayi tektir.");
                }



            }

            else if (sayi == 10)
            {
                Console.WriteLine("Sectigin sayi 10");
            }

            else
            {
                Console.WriteLine(sayi * sayi);
            }
        }
    }
}
