using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ObligatoriskOpgave4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BogController : ControllerBase
    {
        public static List<Bog> BogList = new List<Bog>()
        {
            new Bog("Very Poter", "Gertrud", 12, "1234657980123"),
            new Bog("Little Poter", "Gertrud", 13, "1234657980124"),
            new Bog("Big Poter", "Gertrud", 666, "1234657980125"),
            new Bog("Poter", "Gertrud", 12, "1234657980126")
        };

        // GET: api/Bog
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Bog/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Bog
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Bog/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
