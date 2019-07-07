using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Domain;
using DependencyInjection.Services;
using Microsoft.AspNetCore.Http;
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
        [HttpGet]
        public IEnumerable<Student> GetStudentList()
        {
            return this._studentService.GetAllStudents();
        }
    }
}