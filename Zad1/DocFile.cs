using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public class DocFile
    {
        public static List<DokHandlowy> GetDocuments()
        {
            var resourceName = "Zad1.Resources.dane.txt";

            List<DokHandlowy> documents = null;
            var assembly = Assembly.GetExecutingAssembly();

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))

            using (StreamReader sr = new StreamReader(stream))
            {
                string docJson = sr.ReadToEnd();

                documents = JsonConvert.DeserializeObject<List<DokHandlowy>>(docJson);
                //  return documents ?? new List<DokHandlowy>();
            }
            return documents ?? new List<DokHandlowy>();
        }
    }
}
