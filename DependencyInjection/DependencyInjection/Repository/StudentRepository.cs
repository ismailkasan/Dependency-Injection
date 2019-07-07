﻿using DependencyInjection.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public IEnumerable<Student> GetAll()
        {
            return new List<Student>
            {
                new Student { Id = Guid.NewGuid(), Name = "İsmail" },
                new Student {  Id = Guid.NewGuid(), Name = "Ahmet" }
            };
        }
    }   
}
