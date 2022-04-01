namespace Arayuzler_Example
{
    //abstract class content
    public abstract class Otomobil
    {
        public int tekerleksayisi()
        {
            return 4;
        }
        public virtual renkler renk()
        {
            return renkler.Beyaz;
        }
        public abstract markalar marka();

    }
}