using System;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // çalışan sınıfına ilk defa 11. satırda erişildiğinde 39. satırdaki static constructor methodu 1 defa
            //çalışır ve bir daha çalışmaz.
            Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Mustafa", "Bala", "IK");
            Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);
            Calisan calisan2 = new Calisan("Zekeriye", "Solmaz", "IT");
            Calisan calisan3 = new Calisan("Emre", "Cetin", "IT");
            Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);
            //Calisan calisan4 = new Calisan();


            Console.WriteLine("Toplama sonucu: {0}", Islemler.Topla(100, 500));
            Console.WriteLine("Çıkarma sonucu: {0}", Islemler.Cikar(600, 300));




        }
    }
    class Calisan
    {

        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }
        public Calisan(){}

        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }

    }
    static class Islemler
    {
        //public Islemler()// kurucu methodları yoktur

        
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

    }
}