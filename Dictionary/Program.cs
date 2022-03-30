// See https://aka.ms/new-console-template for more information

Dictionary<int, string> kullanicilar = new Dictionary<int, string>();

kullanicilar.Add(1, "Mustafa");
kullanicilar.Add(12, "Ahmet");
kullanicilar.Add(34, "Özge");
kullanicilar.Add(45, "İlayda");

Console.WriteLine(kullanicilar[1]);
foreach (var item in kullanicilar)
{
    Console.WriteLine(item);
}
Console.WriteLine(kullanicilar.Count);

Console.WriteLine(kullanicilar.ContainsKey(1));
Console.WriteLine(kullanicilar.ContainsValue("Mustafa"));

Console.WriteLine(kullanicilar.Remove(12));

foreach (var item in kullanicilar)
{
    Console.WriteLine(item.Key);
}
foreach (var item in kullanicilar.Values)
{
    Console.WriteLine(item);
}

// example 

int n = Convert.ToInt32(Console.ReadLine());
Dictionary<string, string> phoneBook = new Dictionary<string, string>();
string[] names = new string[n];
for (int i = 0; i < n; i++)
{
    string[] recordInput = Console.ReadLine().Split(' ');
    phoneBook.Add(recordInput[0], recordInput[1]);
}
string nameForSearch = "";
while ((nameForSearch = Console.ReadLine()) != null)
{
    if (phoneBook.ContainsKey(nameForSearch))
    {
        Console.WriteLine(nameForSearch + "=" + phoneBook[nameForSearch]);
    }
    else
    {
        Console.WriteLine("Not found");
    }
}
/*
for (int i = 0; i < n; i++)
{
    //read names to search in phoneBook
    names[i] = Console.ReadLine();
}
foreach (var item in phoneBook)
{
    for (int i = 0; i < n; i++)
    {
        if(item.Key == names[i]){
            Console.WriteLine(item.Key+"="+item.Value);
            break;
        }        
        if(i==n-1){
            Console.WriteLine("Not found");
        }
        

    }
}*/
