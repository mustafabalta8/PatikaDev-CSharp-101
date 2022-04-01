using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Salı);

            Console.WriteLine("Hava Sıcaklığını Giriniz:");
            int n = int.Parse(Console.ReadLine());

            if (n<(int)HavaDurumu.Normal)
            {
            Console.WriteLine("Havanın ısınmasını bekleyelim");
            }
            else if(n >= (int)HavaDurumu.CokSicak)
            {
            Console.WriteLine("Dışarısı fazla sıcak");
            }
            else if(n >= (int)HavaDurumu.Normal && n <(int)HavaDurumu.CokSicak)
            {
            Console.WriteLine("Hadi dışarı çıkalım.");
            }
        }
    }

    enum Gunler
    {
      Pazartesi=1,
      Salı,
      Çarşamba,
      Perşembe,
      Cuma=51,
      Cumartesi,
      Pazar


    }
    enum HavaDurumu
    {
        Soğuk=8,
        Normal=20,
        Sicak=25,
        CokSicak=39
    }
}
