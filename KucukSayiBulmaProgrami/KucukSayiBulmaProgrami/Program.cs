using System;

namespace KucukSayiBulmaProgrami
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int sayi1;
            int sayi2;
            int sayi3;
            Console.WriteLine("Please enter your first number:");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your second number:");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your third number:");
            sayi3 = Convert.ToInt32(Console.ReadLine());
            if (sayi1<sayi2 && sayi1<sayi2)
            {
                Console.WriteLine("The first number is the smallest!");
            }
            else if (sayi2<sayi1 && sayi2<sayi3)
            {
                Console.WriteLine("The second number is the smallest.");
            }
            else if(sayi3<sayi1 && sayi3 < sayi1)
            {
                Console.WriteLine("The third number is the smallest.");
            }
            else
            {
                Console.WriteLine("All 3 numbers are equal to each other.");
            }


        }
}
}

