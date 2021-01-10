using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using System.Resources;

using System.Text;
using System.Threading.Tasks;
using Zad1.Properties;
using System.Reflection;

namespace Zad1
{

    class Program
    {
        static HttpClient client = new HttpClient();

        static async Task RunAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("<<provide your uri>>");
                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("OAuth","xyz");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                Console.WriteLine("Get");
                HttpResponseMessage response = await client.GetAsync("/dokumenty");
                if (response.IsSuccessStatusCode)
                {
                    var get = FindType();
                    
                    DokHandlowy sites = await response.Content.ReadAsAsync<DokHandlowy>();
                    Console.WriteLine("Name: " + sites.Kontrahent + "," + "Year: " + sites.ID);
                }
            }
        }
                public static  List<DokHandlowy> FindType()
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

        /*static public List<DokHandlowy> LoadJson()
        {
            var resourceName = "Properties";

            var datafile = Resources.dane;
            List<DokHandlowy> documents = null;
            var assembly = Assembly.GetExecutingAssembly();

            using (Stream stream = assembly.GetManifestResourceStream(Resources.dane))
            using (StreamReader sr = new StreamReader(stream))
            {
                string docJson = sr.ReadToEnd();
                documents = JsonConvert.DeserializeObject<List<DokHandlowy>>(Resources.dane);
            }
            foreach (DokHandlowy d in documents)
            {
                
                Console.WriteLine(string.Format("ID: {0}  Nazwa kontrahenta: {1}  Kwota: {2}",
                                                d.ID,
                                                d.Kontrahent.Nazwa,
                                                d.KwotaDokumentu));



            }
            return documents ?? new List<DokHandlowy>();
        }  */
       static void Main(string[] args)
        {
            RunAsync().Wait();
            /*   var assembly = Assembly.GetExecutingAssembly();
                 var resourceName = "Zad1.Resources.dane.txt";

                  using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                  using (StreamReader reader = new StreamReader(stream))
                     {
                         string jsonFile = reader.ReadToEnd(); //Make string equal to full file
                     } 

             */
            //var resourceName = "Zad1.Resources.dane.txt";
            FindType().ToList();
           
         /*  var doc =  FindType(resourceName).ToList();
            foreach(DokHandlowy d in doc)
                {
                Console.WriteLine(string.Format("ID: {0}  Nazwa kontrahenta: {1}  Kwota: {2}",
                                                d.ID,
                                                d.Kontrahent.Nazwa,
                                                d.KwotaDokumentu));
            };
            
           Console.WriteLine
            Console.ReadLine();
      
           */
           
        }
            
            

        }
    } 
