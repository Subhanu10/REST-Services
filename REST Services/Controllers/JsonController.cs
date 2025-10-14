using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonThreadOperation.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace REST_Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JsonController : ControllerBase
    {

        private List<Patient> patients = new List<Patient>();
        // GET: api/<JsonController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<JsonController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var patient = patients.Find()
            return "value";
        }

        // POST api/<JsonController>
        [HttpPost]
        public void Create([FromBody] Patient value)
        {
            value.Id = patients.Count + 1;
            patients.Add(value);
        }

        // PUT api/<JsonController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Patient Updatepatient)
        {
            Information Details = new Information();
            Details.UpdatePatient();
        }

        // DELETE api/<JsonController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
