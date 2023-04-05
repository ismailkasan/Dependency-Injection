using System.Collections.Generic;
using DependencyInjection.Domain;
using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService cityService)
        {
            this._studentService = cityService;
        }
        [Route("StudentList")]
        [HttpGet]
        public IEnumerable<Student> GetStudentList()
        {
            return this._studentService.GetAllStudents();
        }
    }
}