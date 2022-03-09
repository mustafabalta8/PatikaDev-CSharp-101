// See https://aka.ms/new-console-template for more information

Console.WriteLine("*** atama ve işlemli atama operatorleri ***");
// atama ve işlemli atama
//
int x = 3;
int y = 5;

y = y + 2;
Console.WriteLine(y);
y /= 1;
Console.WriteLine(y);
x *= 2;
Console.WriteLine(x);

Console.WriteLine("*** mantıksal operatorler ***");
//mantıksal operatorler
// &&, ||, !
bool isSuccess = true;
bool isCompleted = true;

if (isSuccess && isCompleted)
{
    Console.WriteLine("Perfect!");
}
if (isSuccess || isCompleted)
{
    Console.WriteLine("Perfect!");
}
if (isSuccess && !isCompleted)
{
    Console.WriteLine("Fine!");
}

Console.WriteLine("*** iliskisel operatorler ***");
//iliskisel operatorler
// <, > <=, >=, ==, !=

int a = 4;
int b = 8;
bool sonuc = a < b;

Console.WriteLine(sonuc);
sonuc = a > b;
Console.WriteLine(sonuc);
sonuc = a >= b;
Console.WriteLine(sonuc);
sonuc = a <= b;
Console.WriteLine(sonuc);
sonuc = a != b;
Console.WriteLine(sonuc);
sonuc = a == b;
Console.WriteLine(sonuc);

Console.WriteLine("*** aritmetik operatorler ***");
// /, *, +, -

int sayi1 = 10;
int sayi2 = 5;
int sonuc1 = sayi1 / sayi2;

Console.WriteLine(sonuc1); 
sonuc1 = sayi1 * sayi2;
Console.WriteLine(sonuc1);
sonuc1 = sayi1 + sayi2;
Console.WriteLine(sonuc1);
sonuc1 = sayi1 ++;
Console.WriteLine(sayi1);

// % mod alir

int sonuc2 = 28%3;
Console.WriteLine(sonuc2);