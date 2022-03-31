using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        /*Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin
        elemanlarını sıralayan programı yazınız.*/

        string vowels = "aeıioöuü";
        List<char> vowelList = new List<char>();

        Console.WriteLine("bir cümle giriniz!");
        string inputSentece=Console.ReadLine().ToLower();

        foreach(var item in inputSentece){
            if(vowels.Contains(item)){
                vowelList.Add(item);
            }
        }

        if(vowelList.Count > 0){
            foreach (var item in vowelList)
            {
                Console.WriteLine(item);
            }
        }
        else{
            Console.WriteLine("hiç sesli harf bulunamadı.");
        }





    }
}