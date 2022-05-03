using System;

namespace ToplayiciUygulama
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //2- Toplama uygulaması
            //ekrana girilen 2 sayıyı toplayan bir uygulama yaz
            int sayi1;
            int sayi2;
            Console.WriteLine("Hi! Please enter your first number.");
            string girdi1 = Console.ReadLine();
            Console.WriteLine("Please enter your second number");
            string girdi2 = Console.ReadLine();
            sayi1 = Convert.ToInt32(girdi1);
            sayi2 = Convert.ToInt32(girdi2);
            Console.WriteLine(sayi1 + sayi2);
           
        }
    }
}
