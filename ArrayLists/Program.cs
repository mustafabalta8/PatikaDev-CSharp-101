using System;
using System.Collections;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            //liste.Add("Mustafa");
            //liste.Add(6);
            //liste.Add(true);
            //liste.Add('A');

             /*
            Console.WriteLine(liste[0]);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }*/

            Console.WriteLine("**********");
            //string[] renkler = { "Sarı", "Kırmızı", "Yeşil", "Mavi" };
            List<int> sayilar = new List<int>() { 1, 2, 98, 4, 55, 18 };
            //liste.AddRange(renkler);
            liste.AddRange(sayilar);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            liste.Sort(); //Bütün elemanların aynı değişken türünde olması gerekir.
            Console.WriteLine("***sort***");
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            liste.BinarySearch(4); // taratılan verinin hangi indexte olduğunu bulur

            Console.WriteLine("***reverse***");

            liste.Reverse(); // revere the order
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("***Clear***");
            liste.Clear();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

        }
    }
}