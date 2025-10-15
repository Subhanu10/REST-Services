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

        private Information patients = new Information();
        // GET: api/<JsonController>
        [HttpGet]
        public void Get()
        {
            
            patients.GetAllPatients();
           
        }

        // GET api/<JsonController>/5
        [HttpGet("{Patientid}")]
        public Patient GetById(int Id)
        {
            var Patient = patients.GetPatientById(Id);
            if (patients == null)
            {
                return Patient;
            }
            return Patient;



        }

        // POST api/<JsonController>
        [HttpPost]
        public Patient CreatePatient([FromBody] Patient value)
        {
            
            patients.AddPatient(value) ;
             return value;
        }

        // PUT api/<JsonController>/5
        [HttpPut("{id}")]
        public Patient Update([FromBody] Patient Updatepatient)
        {
            patients.UpdatePatient(Updatepatient);
            return Updatepatient;
        }
        // DELETE api/<JsonController>/5
        [HttpDelete("{id}")]
        public void Delete(int Id)
        {
            
            patients.DeletePatient(Id);
            
        }
        [HttpGet("Search/{Keyword}")]
        public void Search([FromQuery] string search)
        {

            patients.SearchPatient(search);
            
     
        }

    }
}
