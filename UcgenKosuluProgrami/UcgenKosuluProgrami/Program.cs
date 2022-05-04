using System;

namespace UcgenKosuluProgrami
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int kenar1;
            int kenar2;
            int kenar3;

            Console.WriteLine("Merhaba, üçgen oluşturmak için istediğiniz 3 kenar uzunluğundan ilkini giriniz.\n Not: Kenar uzunlukları tam sayı olmalıdır.");
            kenar1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci kenar uzunlugunu giriniz.");
            kenar2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üçüncü kenar uzunlugunu giriniz.");
            kenar3 = Convert.ToInt32(Console.ReadLine());
            int toplam = kenar2 + kenar3, Mutlakfark;

            if (kenar2 - kenar3 < 0)
            {
                Mutlakfark = (kenar2 - kenar3) * -1;
            }
            else
            {
                Mutlakfark = kenar2 - kenar3;
            }
            if(Mutlakfark< kenar1 && kenar1 < toplam)
            {
                Console.WriteLine("Üçgen Çizilebilir!");

            }
            else
            {
                Console.WriteLine("Üçgen çizilemez!");

            }
        }
    }
}
