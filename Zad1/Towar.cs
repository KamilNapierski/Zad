namespace Zad1
{
    public enum TypTowaru
    {
        Towar,
        Usługa
    }
    public class Towar
    {
        public int ID { get; set; }
        public string Nazwa { get; set; }
        public string EAN { get; set; }
        public TypTowaru Typ { get; set; }
    }
}