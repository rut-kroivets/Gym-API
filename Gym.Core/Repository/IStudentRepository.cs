﻿using gym_rutiKroivets.Entities;
using gym_rutiKroivets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Gym.Core.Repository
{
    public interface IStudentRepository
    {
        public IEnumerable<Student> Get();

        public ActionResult<Student> Get(int id);

        public Task<Student> PostAsync(Student s);

        public Task PutAsync(int id, Student s);

        public Task DeleteAsync(int id);

    }
}
