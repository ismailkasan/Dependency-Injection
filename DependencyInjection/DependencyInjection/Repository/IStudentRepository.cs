using DependencyInjection.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Repository
{
   public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
    }
}
