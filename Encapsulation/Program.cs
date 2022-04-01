using System;

namespace Encapsulation 
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Zekeriya";
            ogrenci.Soyisim = "Erli";
            ogrenci.OgrenciNo = 15;
            ogrenci.Sinif = 4;
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci2 = new Ogrenci("Mehmet","Doğru",45,1);
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriniGetir();

        }
    }
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }

        public string Soyisim { get => soyisim; set => soyisim = value; } //this is called property
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; } //this is called property
        public int Sinif  //this is called property
        {
            get => sinif;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf en az bir olabilir");
                    sinif = 1;
                }
                else
                    sinif = value;
            }
        }

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
            
        }
        public Ogrenci() { }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("*******Öğrenci Bilgileri********");
            Console.WriteLine("Öğrenci Adı: {0}", this.Isim);
            Console.WriteLine("Öğrenci Soyadı: {0}", this.Soyisim);
            Console.WriteLine("Öğrenci No: {0}", this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıfı: {0}", this.Sinif);

        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }
        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }

    }


}
