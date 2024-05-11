using gym_rutiKroivets.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Core.Service
{
    public interface IStudentService
    {
        public Task<IEnumerable<Student>> GetAsync();

        public Task<Student> GetAsync(int id);

        public Task<Student> PostAsync(Student s);

        public Task PutAsync(int id, Student s);

        public Task DeleteAsync(int id);
    }
}
