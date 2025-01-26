using Microsoft.AspNetCore.Mvc;
using PracticeBusiness.Models;
using PracticeBusiness.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PracticeWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController(IStudentService studentService) : ControllerBase
    {
        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<StudentReadModel> Get([FromQuery] StudentQueryModel queryModel)
        {
            return studentService.Get(queryModel);
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public StudentModel? Get(Guid id)
        {
            return studentService.Get(id);
        }

        // POST api/<StudentController>
        [HttpPost]
        public Guid Post([FromBody] StudentModel model)
        {
            return studentService.Create(model);
        }

        // PUT api/<StudentController>/5
        [HttpPut]
        public void Put([FromBody] StudentModel model)
        {
            studentService.Update(model);
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            studentService.Delete(id);
        }
    }
}
