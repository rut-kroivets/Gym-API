using gym_rutiKroivets.Entities;
using gym_rutiKroivets;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gym.Core.Service;
using Gym.Core.Repository;

namespace Gym.Service
{
    public class StudentService: IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository context)
        {
            _studentRepository = context;
        }       
        public async Task<IEnumerable<Student>> GetAsync()
        {
            return await _studentRepository.GetAsync();
        }
        public async Task<Student> GetAsync(int id)
        {
            return await _studentRepository.GetAsync(id);

        }
        public async Task<Student> PostAsync(Student s)
        {
            await _studentRepository.PostAsync(s);
            return s;
        }
        public async Task PutAsync(int id,  Student s)
        {
            await _studentRepository.PutAsync(id, s);
        }
        public async Task DeleteAsync(int id)
        {
            await _studentRepository.DeleteAsync(id);
        }
    }
}
