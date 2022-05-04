using System;

namespace SwitchCase
{
    class MainClass
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int sayi = Convert.ToInt32(Console.ReadLine());
          
            switch (sayi)
            {
                case 1:

                    Console.WriteLine("Your Number is 1!");
                    break;
                case 2:
                    Console.WriteLine("Your number is 2!");
                    break;
                case 4:
                    Console.WriteLine("Your Number is 4");
                    goto case 1;

                default:
                    Console.WriteLine("Your number isn't 1 or 2!");
                    break;
            }
        }
    }
}
