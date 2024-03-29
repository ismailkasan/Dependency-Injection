﻿using DependencyInjection.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
  public  interface IStudentService
    {
        IEnumerable<Student> GetAllStudents();
    }
}
