﻿using System;

namespace Classes 
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisanlar calisan = new Calisanlar();
            calisan.Ad = "Mustafa";
            calisan.Soyad = "Balta";
            calisan.No = 11;
            calisan.Departman = "IT";
            calisan.CalisanBilgileri();

            Console.WriteLine("******");
            Calisanlar calisan2 = new Calisanlar();
            calisan2.Ad = "Esra";
            calisan2.Soyad = "Taşkıran";
            calisan2.No = 33;
            calisan2.Departman = "Pazarlama";
            calisan2.CalisanBilgileri();
        }
    }

    class Calisanlar
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;


        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı: {0}", Ad);
            Console.WriteLine("Çalışan Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışan Numarası: {0}", No);
            Console.WriteLine("Çalışan Departmanı: {0}", Departman);

        }



    }
}
