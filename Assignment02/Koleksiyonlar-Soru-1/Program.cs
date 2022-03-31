using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        /*Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. 
        (ArrayList sınıfını kullanara yazınız.)       
        */

        ArrayList primeNumbers = new ArrayList();
        ArrayList nonPrimeNumbers = new ArrayList();
        int n, i, m = 0, flag = 0;
        for (i = 0; i < 20; i++)
        {
            Console.WriteLine("Pozitif bir tam sayı giriniz!");
            //Negatif ve numeric olmayan girişleri engelleyin.
            try
            {
                n = int.Parse(Console.ReadLine());
                m = n / 2;
                flag=0;
                for (int j = 2; j <= m; j++)
                {
                    if (n % j == 0)
                    {
                        nonPrimeNumbers.Add(n);
                        flag=1;
                        break;
                    }
                }
                if (flag == 0)
                    primeNumbers.Add(n);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex);
                i--;
            }

        }

        //Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
        primeNumbers.Sort();
        nonPrimeNumbers.Sort();
        primeNumbers.Reverse();
        nonPrimeNumbers.Reverse();

        Console.WriteLine("prime numbers");
        foreach (var item in primeNumbers)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("non prime numbers");
        foreach (var item in nonPrimeNumbers)
        {
            Console.WriteLine(item);
        }

        //Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
        Console.WriteLine("asal olanlar dizesinin eleman sayısı: "+primeNumbers.Count);
        Console.WriteLine("asal olmayanlar dizesinin eleman sayısı: "+nonPrimeNumbers.Count);

        int sum=0;
        foreach(var item in primeNumbers){
            sum+=Convert.ToInt32(item);
        }
        Console.WriteLine("asal sayıların ortalaması: "+sum/primeNumbers.Count);
        sum=0;
        foreach(var item in nonPrimeNumbers){
            sum+=Convert.ToInt32(item);
        }
        Console.WriteLine("asal olmayab sayıların ortalaması: "+sum/nonPrimeNumbers.Count);

    }
}
