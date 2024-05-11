using gym_rutiKroivets.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Core.Service
{
    public interface IGuideService
    {
        public Task<IEnumerable<Guide>> GetAsync();
        public Task<Guide> GetAsync(int id);
        public Task<Guide> PostAsync(Guide g);
        public Task PutAsync(int id, Guide g);
        public Task DeleteAsync(int id);
    }
}
