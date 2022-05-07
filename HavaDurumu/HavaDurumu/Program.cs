using System;

namespace HavaDurumu
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome. Please enter a day.");
            string day = Console.ReadLine();
            switch (day)
            {
                case "Monday":
                    Console.WriteLine("Monday will be 28°C and sunny.");
                    break;
                case "Tuesday":
                    Console.WriteLine("Tuesday will be 21°C and cloudy.");
                    break;
                case "Wednesday":
                    Console.WriteLine("Wednesday will be 25°C and rainy.");
                    break;
                case "Thursday":
                    Console.WriteLine("Thursday will be 31°C and sunny.");
                    break;
                case "Friday":
                    Console.WriteLine("Friday will be 18°C and stormy.");
                    break;

                default:
                    Console.WriteLine("Please enter a valid day.");
                    break;
            }
        }
    }
}
