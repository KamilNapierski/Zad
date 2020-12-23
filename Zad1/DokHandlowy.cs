using System;
using System.Collections.Generic;
using System.Linq;

namespace Zad1
{
    public class DokHandlowy
    {
        public int ID { get; set; }
        public string Numer { get; set; }
        public DateTime Data { get; set; }
        public Kontrahent Kontrahent { get; set; }
        public List<PozycjaDokHandlowego> Pozycje { get; set; }
        public decimal KwotaDokumentu
        {
            get
            {
                return this.Pozycje != null ? this.Pozycje.Sum(p => p.Cena) : 0;
            }
        }
    }

}
