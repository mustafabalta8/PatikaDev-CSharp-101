using System;

namespace Classes 
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisanlar calisan = new Calisanlar();
            calisan.ad = "Mustafa";
            calisan.soyad = "Balta";
            calisan.no = 11;
            calisan.departman = "IT";
            calisan.CalisanBilgileri();
            Console.WriteLine("******");
            calisan.ad = "Esra";
            calisan.soyad = "Taşkıran";
            calisan.no = 33;
            calisan.departman = "Pazarlama";
            calisan.CalisanBilgileri();
        }
    }

    class Calisanlar
    {
        public string ad;
        public string soyad;
        public int no;
        public string departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı: {0}", ad);
            Console.WriteLine("Çalışan Soyadı: {0}", soyad);
            Console.WriteLine("Çalışan Numarası: {0}", no);
            Console.WriteLine("Çalışan Departmanı: {0}", departman);

        }



    }
}
