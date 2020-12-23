using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public class UseData
    {
        public static List<DokHandlowy> GetData()
        {
            LoadData loaddata = new LoadData("C:\\KamilNapieralski-master\\Zad1\\Resources\\dane.txt");
            List<DokHandlowy> documents = loaddata.LoadJson();
            return documents;
        }
    }
}
