using System;

namespace HesapMakinesi
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int sayi1;
            int sayi2;
            

            Console.WriteLine("Welcome. Please enter your first number.");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Welcome. Please enter your second number.");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the math operation you want to do. + - / *");
            string islemler = Console.ReadLine();
            switch (islemler)
            {
                case "+":
                    Console.WriteLine(sayi1 + sayi2);
                    break;
                case "-":
                    Console.WriteLine(sayi1 - sayi2);
                    break;
                case "*":
                    Console.WriteLine(sayi1 * sayi2);
                    break;
                case "/":
                    Console.WriteLine(sayi1 / sayi2);
                    break;
                default:
                    break;
            }



        }
    }
}
