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

        private static List<Patient> patients = new List<Patient>();

        // GET: api/<JsonController>
        [HttpGet]
        public IActionResult GetPatient()
        {
            try
            {
                return Ok(patients);
            }
             catch(Exception ex)
            {
                throw ex;
            }
           
        }

        // GET api/<JsonController>/5
        [HttpGet("{Id}")]
        public IActionResult GetById(int Id)
        {
            try
            {

                
                var Data = patients.Find(p=> p.Id == Id);
                if (Data == null)
                {
                    return NotFound();
                }
                return Ok(Data);

            }
            catch(Exception ex)
            {
                throw ex;

            }

        }

        // POST api/<JsonController>
        [HttpPost]
        public IActionResult CreatePatient([FromBody] Patient value)
        {
            try
            {
                value.Id = patients.Count + 1;
                patients.Add(value);
                return CreatedAtAction(nameof(GetPatient),new { id = value.Id },value);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<JsonController>/5
        [HttpPut("{Id}")]
        public IActionResult UpdatePatient(int Id,[FromBody] Patient patient)
        {
            try
            {
                var exsitingPatient = patients.Find(p => p.Id == Id);
                if (exsitingPatient == null)
                {
                    return NotFound();
                }
                
                    exsitingPatient.Name = patient.Name;
                    exsitingPatient.MobileNumber = patient.MobileNumber;
                    exsitingPatient.Email = patient.Email;
                    exsitingPatient.Location = patient.Location;
                    exsitingPatient.Address = patient.Address;
                
                return Ok(exsitingPatient);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        // DELETE api/<JsonController>/5
        [HttpDelete("{Id}")]
        public IActionResult DeletePatient(int Id)
        {
            try
            {
                var patient = patients.Find(s => s.Id == Id);
                if(patient == null)
                {
                    return NotFound();
                }
                patients.Remove(patient);
                return NoContent();
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
        [HttpGet("Search")]
        public IActionResult SearchPatient([FromQuery] string search)
        {
            try
            { 
                var result = patients
                    .Where(p => p.Name.ToLower().Contains(search.ToLower()) ||
                    p.MobileNumber.ToString().Contains(search.ToLower()) || 
                    p.Email.ToLower().Contains(search.ToLower())).ToList();
                return Ok(result);
            }
            catch(Exception ex)
            {
                throw ex;
            }
     
        }

    }
}
