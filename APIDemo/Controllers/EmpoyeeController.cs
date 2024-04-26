using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIDemo.Controllers
{
  
        [Route("api/[controller]")]
        [ApiController]
        public class EmployeeController : ControllerBase
        {
            static List<Employee> employees = new List<Employee>();
            // GET: api/<EmployeeController>
            [HttpGet]
            public IEnumerable<Employee> Get()
            {
                return employees;
            }

            // GET api/<EmployeeController>/5
            [HttpGet("{id}")]
            public Employee Get(int id)
            {
                return employees.FirstOrDefault(s => s.Id == id);
            }

            // POST api/<EmployeeController>
            [HttpPost]
            public void Post([FromBody] Employee value)
            {
                employees.Add(value);
            }

            // PUT api/<EmployeeController>/5
            [HttpPut("{id}")]
            public void Put(int id, [FromBody] Employee value)
            {
                int i = employees.FindIndex(s => s.Id == id);
                if (i >= 0)
                    employees[i] = value;
            }

            // DELETE api/<EmployeeController>/5
            [HttpDelete("{id}")]
            public void Delete(int id)
            {
                employees.RemoveAll(s => s.Id == id);
            }
        }
    }
