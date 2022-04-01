namespace Inheritance
{
    public class Hayvanlar : Canlilar
    {
        protected void SuruHalindeHareket()
        {
            Console.WriteLine("Hayvanlar sürüler halinde hareket eder.");
        }
    }

    public class Kuslar : Hayvanlar
    {
        public Kuslar()// kuslar nesnesi yaratıldığında bu varsayılan constructor methodu çalışacak
        {
            base.SuruHalindeHareket();
            base.Beslenme();

        }
        public void Ucmak()
        {
            Console.WriteLine("Kuşlar uçar");
        }
    }

    public class Sürüngenler : Hayvanlar
    {
        public Sürüngenler()
        {
            base.SuruHalindeHareket();
            base.Beslenme();
        }

        public void Yuzmek()
        {
            Console.WriteLine("sürüngenler sürünür");
        }
    }

}
