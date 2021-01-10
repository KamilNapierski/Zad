using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Zad1;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        private List<DokHandlowy> _dok = DocFile.GetDocuments();
        


        [HttpGet("/dokumenty")]
         public IActionResult GetDocAndSum()
        {


            var sum = (from ord in _dok
                        select ord.KwotaDokumentu).Sum();

            
            var doc = JsonConvert.SerializeObject(_dok, Formatting.Indented);
            
            var sumDoc = JsonConvert.SerializeObject(sum, Formatting.Indented);
                if (doc == null) 
                {
                    return NotFound();
                };
           
            return Ok(doc +"Suma Wszystkich Dokumentów" + sum);

        }

        [HttpGet("/dokumenty/{idDokumentu}")]
        public IActionResult GetDocById(int idDokumentu)
        {
            var DocById =  _dok.FirstOrDefault(p=>p.ID == idDokumentu);
            
                if (DocById == null)
                {
                    return NotFound();
                };
             
            return Ok(JsonConvert.SerializeObject(DocById, Formatting.Indented));
        }
        [HttpGet("/kontrahenci")]
        public IActionResult GetKontrahent()
        {


            var Kontrahentci = _dok.Select(p => p.Kontrahent).ToList();
                 if(Kontrahentci == null)
                 {
                    return NotFound("Coś poszło nie tak ");
                 };
            
            return Ok( JsonConvert.SerializeObject(Kontrahentci, Formatting.Indented));

        }

        [HttpGet("/dokumentyWgKontrahent/{idKontrahenta}")]
        public IActionResult GetDocKontrahentById(int idKontrahenta)
        {
            

            var DocKontrahentById = _dok.FirstOrDefault(p => p.Kontrahent.ID == idKontrahenta);
                
                if(DocKontrahentById == null)
                {
                    return NotFound("Ćos poszło nie tak ");
                };
            
            return Ok ( JsonConvert.SerializeObject(DocKontrahentById, Formatting.Indented));

        }
    }
}

