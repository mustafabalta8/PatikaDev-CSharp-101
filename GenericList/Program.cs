using System;
using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(1);
            sayilar.Add(10);
            sayilar.Add(5);
            sayilar.Add(4);
            sayilar.Add(0);
            sayilar.Add(6);
            sayilar.Add(16);

            List<string> renkler = new List<string>();
            renkler.Add("Mavi");
            renkler.Add("Sarı");
            renkler.Add("Yeşil");
            renkler.Add("Kırmızı");
            renkler.Add("Turuncu");

            Console.WriteLine(sayilar.Count);
            Console.WriteLine(renkler.Count);

            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }
            foreach (var item in renkler)
            {
                Console.WriteLine(item);
            }

            sayilar.ForEach(sayi => Console.WriteLine(sayi));
            renkler.ForEach(renk => Console.WriteLine(renk));


            sayilar.Remove(1);
            renkler.Remove("Mavi");

            sayilar.RemoveAt(0);
            renkler.RemoveAt(0);


            sayilar.ForEach(sayi => Console.WriteLine(sayi));
            renkler.ForEach(renk => Console.WriteLine(renk));


            if (sayilar.Contains(3))
                Console.WriteLine("Listede vardır.");

            Console.WriteLine(renkler.BinarySearch("Turuncu"));

            string[] hayvanlar = { "Kedi", "Kuş", "Fil", "Maymun" };
            List<string> hayvanList = new List<string>(hayvanlar);

            hayvanList.Clear();

            List<Kullanicilar> kullanicilars = new List<Kullanicilar>();
            Kullanicilar k1 = new Kullanicilar();

            k1.Isim = "Mustafa";
            k1.Soyad = "Balta";
            k1.Yas = 27;

            Kullanicilar k2 = new Kullanicilar();

            k2.Isim = "Salih";
            k2.Soyad = "Korkutan";
            k2.Yas = 33;

            kullanicilars.Add(k1);
            kullanicilars.Add(k2);


            List<Kullanicilar> yeniListe = new List<Kullanicilar>();

            yeniListe.Add(new Kullanicilar()
            {
                Isim = "Ayşe",
                Soyad = "Kul",
                Yas = 22

            });

            foreach (var item in kullanicilars)
            {
                Console.WriteLine(item.Isim);
                Console.WriteLine(item.Soyad);
                Console.WriteLine(item.Yas);
            }
            foreach (var item in yeniListe)
            {
                Console.WriteLine(item.Isim);
                Console.WriteLine(item.Soyad);
                Console.WriteLine(item.Yas);
            }

        // hacerrank exercise
        int n = Convert.ToInt32(Console.ReadLine());
		int[] intArray = new int[n];
		for (int i = 0; i < n; i++)
		{
			intArray[i] = Convert.ToInt32(Console.ReadLine());
		}
		
		n = Convert.ToInt32(Console.ReadLine());
		string[] stringArray = new string[n];
		for (int i = 0; i < n; i++)
		{
			stringArray[i] = Console.ReadLine();
		}
		
		PrintArray<Int32>(intArray);
		PrintArray<String>(stringArray);

        }
        // hacerrank exercise 
        public static void PrintArray<T>(T[] array)
        {
            foreach (var element in array)
                Console.WriteLine(element);
        }
    }

    public class Kullanicilar
    {
        private string isim;
        private string soyad;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public int Yas { get => yas; set => yas = value; }
    }

}