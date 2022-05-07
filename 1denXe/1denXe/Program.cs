using System;

namespace denXe
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //1den-X sayisina kadar olan sayilari ekrana yazdir. X sayisi kullanıcıdan alınacak

            int xsayisi;
            Console.WriteLine("Welcome.Please enter a number.");
            xsayisi = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= xsayisi; i++)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
