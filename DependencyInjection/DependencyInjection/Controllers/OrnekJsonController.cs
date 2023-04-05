using System.Collections.Generic;
using System.Linq;
using DependencyInjection.Domain;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrnekJsonController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            List<Member> liste = new()
            {
                new Member { Name= "John", LastName= "Doe" },
                new Member { Name = "Anna", LastName = "Smith" },
                new Member { Name = "Peter", LastName = "Jones" }
            };
            return JsonConvert.SerializeObject(liste);
        }

        [HttpGet("GetOlustur")]
        public ActionResult<IEnumerable<Member>> GetOlustur()
        {
            string json= @"[{""Name"":""John"",""LastName"":""Doe""},{""Name"":""Anna"",""LastName"":""Smith""},{""Name"":""Peter"",""LastName"":""Jones""}]";

            var liste = (List<Member>)JsonConvert.DeserializeObject(json, typeof(List<Member>));
            return liste.ToList();
        }
    }
}