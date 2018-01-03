using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI_Homework2.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
       
        [HttpGet]
        public IEnumerable<string> Get()
        {

            return new string[] { "Student1", "Student2" };
        }

  
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

 
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }


        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
