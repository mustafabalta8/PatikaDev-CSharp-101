using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        //Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun 
        //kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı 
        //yazınız. (Array sınıfını kullanarak yazınız.)
        ArrayList numbers = new ArrayList();
        for (int i = 0; i < 5; i++)
        {
            int newNumber = Convert.ToInt32(Console.ReadLine());
            numbers.Add(newNumber);
        }
        float biggestNumbersAverage = 0, smallestNumbersAverage = 0;
        int biggestNumbersSum = 0, smallestNumbersSum = 0;
        numbers.Sort();
        for (int i = 0; i < 3; i++)
        {
            smallestNumbersSum += Convert.ToInt32(numbers[i]);
        }
        smallestNumbersAverage=smallestNumbersSum/3;
        Console.WriteLine("en küçük sayılar ortalaması: "+smallestNumbersAverage);
        Console.WriteLine("en küçük sayılar ortalaması toplamı: "+(smallestNumbersAverage*3));

        numbers.Reverse();
        for (int i = 0; i < 3; i++)
        {
            biggestNumbersSum += Convert.ToInt32(numbers[i]);
        }
        biggestNumbersAverage=biggestNumbersSum/3;
        Console.WriteLine("en büyük sayılar ortalaması: "+biggestNumbersAverage);
        Console.WriteLine("en büyük sayılar ortalaması toplamı: "+(biggestNumbersAverage*3));

        Console.WriteLine("ortalamaların toplamları: "+(smallestNumbersAverage+biggestNumbersAverage));




    }
}
