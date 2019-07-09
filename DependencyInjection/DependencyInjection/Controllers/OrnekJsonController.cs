using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrnekJsonController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            List<Member> liste = new List<Member>
            {
                new Member { Name= "John", LastName= "Doe" },
                new Member { Name = "Anna", LastName = "Smith" },
                new Member { Name = "Peter", LastName = "Jones" }
            };
            string json = JsonConvert.SerializeObject(liste);
            return json;
        }

        [HttpGet("GetOlustur")]
        public ActionResult<IEnumerable<Member>> GetOlustur()
        {
            string json= @"[{""Name"":""John"",""LastName"":""Doe""},{""Name"":""Anna"",""LastName"":""Smith""},{""Name"":""Peter"",""LastName"":""Jones""}]";

      

            var liste2 = new List<Member>();
            var liste = (List<Member>)JsonConvert.DeserializeObject(json, typeof(List<Member>));
            return liste.ToList();
        }
    }
}