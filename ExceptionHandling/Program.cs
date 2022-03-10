// See https://aka.ms/new-console-template for more information


// try
// {
//     Console.WriteLine("bi sayi giriniz.");
//     int num = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Girdiginiz sayi: " + num);

// }
// catch (Exception ex)
// {
//     Console.WriteLine("Hata: " + ex);


// }
// finally{
//     Console.WriteLine("işlem tamam");
// }


try
{
    //int a = int.Parse(null);
    //int a = int.Parse("test");
    int a = int.Parse("-200000000000");
    
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Boş değer girdiniz.");
    Console.WriteLine(ex);
}
catch (FormatException ex)
{
    Console.WriteLine("Veri tipi uygun değil.");
    Console.WriteLine(ex);
}
catch (OverflowException ex)
{
    Console.WriteLine("Çok küçük yada çok büyük bir değer girdiniz.");
    Console.WriteLine(ex);
}
finally
{
    Console.WriteLine("İşlem başarıyla tamamlandı.");
}