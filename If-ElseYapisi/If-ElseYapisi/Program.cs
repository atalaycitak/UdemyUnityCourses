using System;

namespace IfElseYapisi
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");

            int sayi = Convert.ToInt32(Console.ReadLine());

            if(sayi == 31)
            {
                Console.WriteLine("sj :D");
            }

            else if (sayi > 10)
            {
                Console.WriteLine("This number is higher than 10!");
            }

            else if(sayi == 5)
            {
                Console.WriteLine("This number is 5");
            }



            else
            {
                Console.WriteLine("This number is lower than 10");
            }


        }
    }
}
