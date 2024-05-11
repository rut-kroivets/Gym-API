using gym_rutiKroivets.Entities;
using gym_rutiKroivets;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gym.Core.Repository;
using Microsoft.EntityFrameworkCore;

namespace Gym.Data.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DataContext _dataContext;
        public StudentRepository(DataContext context)
        {
            _dataContext = context;
        }

        public async Task<IEnumerable<Student>> GetAsync()
        {
            return await _dataContext.students.ToListAsync();
        }

        public async Task<Student> GetAsync(int id)
        {
            return await _dataContext.students.FindAsync(id);
        }
        public async Task<Student> PostAsync(Student s)
        {           
            _dataContext.students.Add(s);
            await _dataContext.SaveChangesAsync();
            return s;
        }
        public async Task PutAsync(int id,Student s)
        {
            var stud = _dataContext.students.Find(id);
            stud.Name = s.Name;
            stud.Address = s.Address;
            stud.Age = s.Age;
            await _dataContext.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var stud = _dataContext.students.Find(id);
            _dataContext.students.Remove(stud);
            await _dataContext.SaveChangesAsync();
        }
    }
}
