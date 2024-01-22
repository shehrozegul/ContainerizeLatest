using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Search.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchItem : ControllerBase
    {
        // GET: api/<SearchItem>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SearchItem>/5
        [HttpGet("{id}/{relevance}/{date}/{criteria}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SearchItem>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SearchItem>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SearchItem>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
