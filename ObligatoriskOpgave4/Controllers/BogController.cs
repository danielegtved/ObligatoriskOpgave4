using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ObligatoriskOpgave1;

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
        public IEnumerable<Bog> Get()
        {
            return BogList;
        }

        // GET: api/Bog/5
        [HttpGet("{isbn}", Name = "Get")]
        public Bog Get(string isbn)
        {
            return BogList.Find(bog => bog.Isbn == isbn);
        }

        // POST: api/Bog
        [HttpPost]
        public void Post([FromBody] Bog value)
        {
            BogList.Add(value);
        }

        // PUT: api/Bog/5
        [HttpPut("{isbn}")]
        public void Put(string isbn, [FromBody] Bog value)
        {
            Bog bog = Get(isbn);
            if (bog != null)
            {
                bog.Isbn = value.Isbn;
                bog.Titel = value.Titel;
                bog.SideTal = value.SideTal;
                bog.Forfatter = value.Forfatter;
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{isbn}")]
        public void Delete(string isbn)
        {
            Bog bog = Get(isbn);
            BogList.Remove(bog);
        }
    }
}
