using System;


namespace Inheritance
{
    class Program
    {
        //                     canlılar
        //       bitkiler                            hayvanlar
        //ağaçlar         otlar           kanatlılar          sürüngenler
        static void Main(string[] args)
        {
            Kuslar martı = new Kuslar();
            //martı.Beslenme();
            martı.Bosaltim();
            martı.Solunum();
            //martı.SuruHalindeHareket();
            martı.Ucmak();

            Console.WriteLine("**********");

            TohumluBitkiler papatya = new TohumluBitkiler();
            //papatya.Beslenme();
            papatya.Bosaltim();
            //papatya.FotosentezYapmak();
            papatya.Solunum();
            papatya.TohumlaCogalma();
      
        }
    }
}
