using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Domain;
using DependencyInjection.Repository;

namespace DependencyInjection.Services
{
    public class StudentService:IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            this._studentRepository = studentRepository;
        }
        public IEnumerable<Student> GetAllStudents()
        {
            return this._studentRepository.GetAll();
        }
    }
}
