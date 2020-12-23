namespace Zad1
{
    public class PozycjaDokHandlowego
    {
        public int ID { get; set; }
        public string Nazwa { get; set; }
        public double Ilosc { get; set; }
        public Towar Towar { get; set; }
        public string Jednostka { get; set; }
        public decimal Cena { get; set; }
    }
}