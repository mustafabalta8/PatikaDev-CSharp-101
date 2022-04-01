﻿using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen d = new Dikdortgen();
            d.KisaKenar = 4;
            d.UzunKenar = 15;
            Console.WriteLine("Class Alan Hesaplama: {0}", d.AlanHesaplama());


            Dikdortgen_s d_struct; //= new Dikdortgen_s(4, 15);
            d_struct.KisaKenar=3;
            d_struct.UzunKenar=4;
            Console.WriteLine("Struct Alan Hesaplama: {0},", d_struct.AlanHesaplama());


        }
    }
    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;

        public Dikdortgen()
        {
            KisaKenar = 4;
            UzunKenar = 15;
        }
        public long AlanHesaplama()
        {
            return this.KisaKenar * this.UzunKenar;

        }



    }
    struct Dikdortgen_s
    {
        public int KisaKenar;
        public int UzunKenar;

        public Dikdortgen_s(int kisaKenar, int uzunKenar)
        {
            KisaKenar = kisaKenar;
            UzunKenar = uzunKenar;
        }
        //public Dikdortgen_s(){}

        public long AlanHesaplama()
        {
            return this.KisaKenar * this.UzunKenar;

        }


    }
}
