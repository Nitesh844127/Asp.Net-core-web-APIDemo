using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollegeController : ControllerBase
    {
        static List<College> colleges = new List<College>();
        // GET: api/<CollegeController>
        [HttpGet]
        public IEnumerable<College> Get()
        {
            return colleges;
        }

        // GET api/<CollegeController>/5
        [HttpGet("{id}")]
        public College Get(int id)
        {
            return colleges.FirstOrDefault(s => s.Id == id);
        }

        // POST api/<CollegeController>
        [HttpPost]
        public void Post([FromBody] College value)
        {
            colleges.Add(value);
        }

        // PUT api/<CollegeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] College value)
        {
           int i= colleges.FindIndex( s => s.Id == id);
            if(i>=0)
                colleges[i]= value;

        }

        // DELETE api/<CollegeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            colleges.RemoveAll(s => s.Id == id); 
        }
    }
}
