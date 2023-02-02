using Microsoft.AspNetCore.Mvc;
using Training.DataAccess;
using System.Data.Sql;
using System.Data.SqlClient;

namespace StudentApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        [HttpGet("GetStudents/{firstName}")]
        public IActionResult Index(string firstName)
        {
            var advWorksDA = new AdventureWorksDataAccess();
            var students = advWorksDA.GetStudentByFirstName(firstName);
            return Ok(students);
        }
    }
}
