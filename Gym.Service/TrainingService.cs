using Gym.Core.Repository;
using Gym.Core.Service;
using gym_rutiKroivets.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Service
{
    public class TrainingService:ITrainingService
    {
        private readonly ITrainingRepository _trainingRepository;
        public TrainingService(ITrainingRepository context)
        {
            _trainingRepository = context;
        }
        public IEnumerable<Training> Get()
        {
            return _trainingRepository.Get();
        }
        public ActionResult<Training> Get(int id)
        {
            return _trainingRepository.Get(id);

        }
        public async Task<Training> PostAsync(Training t)
        {
            await _trainingRepository.PostAsync(t);
            return t;

        }
        public async Task PutAsync(int id,Training s)
        {
            await _trainingRepository.PutAsync(id, s);
        }
        public async Task DeleteAsync(int id)
        {
            await _trainingRepository.DeleteAsync(id);
        }
    }
}
