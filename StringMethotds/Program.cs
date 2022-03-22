// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string degisken = "Dersimiz CSharp, Hoşgeldiniz.";
string degisken2 = "Dersimiz C#.";
//Length 
Console.WriteLine(degisken.Length);

//ToUpper() => büyük yazdırır
//ToLower() => küçük yazdırır
Console.WriteLine(degisken.ToLower());
Console.WriteLine(degisken.ToUpper());

//Concat(degisken,eklemek istenilen) => değerin sonuna ekleme işlemi yapar.

Console.WriteLine(String.Concat(degisken, " Merhaba!"));

/*Compare => dönüş değeri sıfır (0) ise iki metin birbirine eşittir. 
Aksi takdirde parametre olarak verilen metinleri ilk harflerinden itibaren tek tek karşılaştırır 
ve farklılığın olduğu ilk harflerin alfabedeki sıralarına göre -1 veya 1 sayı değerlerini döndürür.*/
//CompareTo => String Compare yöntemi ile iki tane string değer karşılaştırılır.  Karşılaştırma da büyük küçük 
//harf kontrolü ile sıralaması kontrol edilir.
Console.WriteLine(degisken.CompareTo(degisken2));
Console.WriteLine(String.Compare(degisken, degisken2, false));
Console.WriteLine(String.Compare(degisken, degisken2, true));

//Contains
Console.WriteLine(degisken.Contains(degisken2));
Console.WriteLine(degisken.EndsWith("Hoşgeldiniz."));
Console.WriteLine(degisken.StartsWith("Merhaba!"));

//IndexOf

Console.WriteLine(degisken.IndexOf("C#"));
Console.WriteLine(degisken.IndexOf("ZEK"));
Console.WriteLine(degisken.LastIndexOf("i"));

//Insert
Console.WriteLine(degisken.Insert(0, "Merhaba "));

//PadLeft - PadRight
Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
Console.WriteLine(degisken.PadRight(50, '-') + degisken2);

//Remove
Console.WriteLine(degisken.Remove(10));
Console.WriteLine(degisken.Remove(5, 3));
Console.WriteLine(degisken.Remove(0, 1));

//Replace
Console.WriteLine(degisken.Replace("CSharp", "C#"));
Console.WriteLine(degisken.Replace(" ", "*"));

//Split
string split1 = degisken.Split(" ")[1];
Console.WriteLine(split1);


//SubString
Console.WriteLine(degisken.Substring(4));

Console.WriteLine("*** ALIŞTIRMA ***");

/* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    string S = Convert.ToString(Console.ReadLine());
    MyFunction(S);

}

void MyFunction(string S)
{

    char[] ch = new char[S.Length];
    for (int i = 0; i < S.Length; i++)
    {
        ch[i] = S[i];
    }

    List<char> evenList = new List<char>();
    List<char> oddList = new List<char>();
    for (int i = 0; i < S.Length; i++)
    {
        if (i % 2 == 0)
        {
            //Console.Write(ch[i]);
            evenList.Add(ch[i]);
        }
        //Console.Write(" ");
        if (i % 2 != 0)
        {
            //Console.Write(ch[i]);
            oddList.Add(ch[i]);
        }

    }
    evenList.ForEach(item => Console.Write(item));
    Console.Write(" ");
    oddList.ForEach(item => Console.Write(item));


}