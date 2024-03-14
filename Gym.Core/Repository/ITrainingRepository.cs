using gym_rutiKroivets.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Core.Repository
{
    public interface ITrainingRepository
    {
        public IEnumerable<Training> Get();

        public ActionResult<Training> Get(int id);

        public Task<Training> PostAsync(Training t);

        public Task PutAsync(int id, Training s);

        public Task DeleteAsync(int id);
    }
}
