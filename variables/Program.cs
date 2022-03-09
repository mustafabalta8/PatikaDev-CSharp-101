using System;

class Program
{
    static void Main(string[] args)
    {

        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World!");

        byte a = 1;
        sbyte b = 1;

        short c = 2;
        ushort d = 2;

        Int16 e = 2;
        int i = 4;
        Int32 i32 = 4;
        Int64 i64 = 8;

        uint ui = 4;
        long ul = 8;
        ulong ull = 8;

        //reel numbers

        float f = 4;
        double dd = 8;
        decimal de = 16;


        bool b1 = true;

        DateTime dt = DateTime.Now;
        Console.WriteLine(dt);

        object o1 = "asd";
        object o2 = 'a';
        object o3 = 4;
        object o4 = 4.23;

        //strings

        string str1 = string.Empty;
        str1 = "Mustafa Balta";
        string ad = "Mustafa";
        string soyad = "Balta";
        string tamIsim = ad + " " + soyad;

        int integer1 = 5;
        int integer2 = 3;
        int integer3 = integer1 * integer2;

        bool bool1 = 10 < 2;

        string str20 = "20";
        int int20 = 20;
        string yeniDeger = str20 + int20.ToString();
        Console.WriteLine(yeniDeger);

        int int21 = int20 + Convert.ToInt32(str20);
        Console.WriteLine(int21);

        int int22 = int20 + int.Parse(str20);

        string datetime = DateTime.Now.ToString("dd.MM.yyyy");
        Console.WriteLine(datetime);

        string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
        Console.WriteLine(datetime2);

        string hour = DateTime.Now.ToString("HH:mm");
        Console.WriteLine(hour);


    }
}

