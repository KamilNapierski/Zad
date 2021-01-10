using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad1;

namespace ConsoleData
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DokHandlowy> _dok = DocFile.GetDocuments();

            var doc = _dok.OrderByDescending(p => p.KwotaDokumentu).ToList();

                foreach (DokHandlowy d in doc)
                {
                    Console.WriteLine(string.Format("ID: {0}  Nazwa kontrahenta: {1}  Kwota: {2}",
                                                    d.ID,
                                                    d.Kontrahent.Nazwa,
                                                    d.KwotaDokumentu));
                }
            
            
                Console.ReadKey();
        }
    }
}
