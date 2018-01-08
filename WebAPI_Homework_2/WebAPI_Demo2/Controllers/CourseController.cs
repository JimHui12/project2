using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Demo2.Controllers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI_Homework2.Controllers
{

    [Route("api/[controller]")]
    public class CourseController : Controller
    {

        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(DataStore.Instance().GetAllCourses());
        }


        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            return new JsonResult(DataStore.Instance().GetCourseByID(id));
        }


        [HttpPost]
        public void Post([FromBody]Course newCourse)
        {
            DataStore.Instance().AddCourse(newCourse);
        }


        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Course updateCourse)
        {
            DataStore.Instance().UpdateCourse(updateCourse);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            DataStore.Instance().DeleteCourse(id);
        }
    }
}
