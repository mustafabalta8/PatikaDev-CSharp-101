namespace Inheritance
{
    public class Canlilar
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlılar beslenir.");
        }
        public void Solunum()
        {
            Console.WriteLine("Canlılar solunum yapar.");
        }

        public void Bosaltim()
        {
            Console.WriteLine("Canlılar boşaltım Yapar.");
        }
        public virtual void UyaranlaraTepki(){
            Console.WriteLine("Canlılar uyaranlara tepki verir.");
        }
    }
}