using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class LoadData
    {
        private string docPath;

        public LoadData(string docPath)
        {
            this.docPath = docPath;
        }

        public List<DokHandlowy> LoadJson()
        {
            List<DokHandlowy> documents = null;
            using (StreamReader sr = new StreamReader(docPath))
            {
                string docJson = sr.ReadToEnd();
                documents = JsonConvert.DeserializeObject<List<DokHandlowy>>(docJson);
            }
            return documents ?? new List<DokHandlowy>();
        }
    }
}
