using System;

namespace GeziRehberiProgrami
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hi. Please select a city.\n a- Ankara b- Istanbul c- Kayseri d- Balikesir");
            string secim = Console.ReadLine();
            if (secim == "a")
            {
                Console.WriteLine("You should visit Anitkabir!");
            }
            else if (secim == "b")

            {
                Console.WriteLine("You should watch Fenerbahce Ulker's Euroleague match.");
            }
            else if (secim == "c")
            {
                Console.WriteLine("You should visit the Castle in the Republic Square.");
            }
            else if (secim == "d")
            {
                Console.WriteLine("You should go to the beach and have fun!");
            }
            else
            {
                Console.WriteLine("Please enter another word.(a, b, c or d)");
            }


        }
    }
}
