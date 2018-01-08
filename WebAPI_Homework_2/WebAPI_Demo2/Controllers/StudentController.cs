using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Demo2.Controllers;

namespace WebAPI_Homework2.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
       
        [HttpGet]
        public JsonResult Get()
        {

            return new JsonResult(DataStore.Instance().GetAllStudents());
        }

  
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            return new JsonResult(DataStore.Instance().GetStudenteByID(id));
        }

 
        [HttpPost]
        public void Post([FromBody]Student newStudent)
        {
            DataStore.Instance().AddStudent(newStudent);
        }


        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Student updateStudent)
        {
            DataStore.Instance().UpdateStudent(updateStudent);
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            DataStore.Instance().DeleteStudent(id);
        }
    }
}
