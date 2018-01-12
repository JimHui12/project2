using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Demo2.Controllers;

namespace WebAPI_Homework2.Controllers
{

    [Route("api/[controller]")]
    public class LecturerController : Controller
    {

        [HttpGet]
        public JsonResult Get()
        {
            
            return new JsonResult(DataStore.Instance().GetAllLecturers());
        }


        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            return new JsonResult(DataStore.Instance().GetLecturersByID(id));
        }


        [HttpPost]
        public void Post([FromBody]Lecturer newLecturer)
        {
            DataStore.Instance().AddLecturer(newLecturer);
        }


        [HttpPut()]
        public void Put(int id, [FromBody] Lecturer updateLecturer)
        {
            DataStore.Instance().UpdateLecturer(updateLecturer);
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            DataStore.Instance().DeleteLecturer(id);
        }
    }
}
