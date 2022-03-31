using System;

namespace ConstructorMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisanlar calisan = new Calisanlar("Mustafa","Balta",18,"IK");
            /*calisan.Ad = "Mustafa";
            calisan.Soyad = "Balta";
            calisan.No = 11;
            calisan.Departman = "IT";*/
            calisan.CalisanBilgileri();

            Console.WriteLine("******");
            Calisanlar calisan2 = new Calisanlar();
            calisan2.Ad = "Esra";
            calisan2.Soyad = "Taşkıran";
            calisan2.No = 33;
            calisan2.Departman = "Pazarlama";
            calisan2.CalisanBilgileri();

            Console.WriteLine("******");
            Calisanlar calisan3 = new Calisanlar("Temel", "Yorulmaz");
            calisan3.CalisanBilgileri();
            
        }
    }

    class Calisanlar
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisanlar(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;

        }
        public Calisanlar() { }

        public Calisanlar(string ad, string soyad){
            this.Ad=ad;
            this.Soyad=soyad;
        }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı: {0}", Ad);
            Console.WriteLine("Çalışan Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışan Numarası: {0}", No);
            Console.WriteLine("Çalışan Departmanı: {0}", Departman);

        }



    }
}