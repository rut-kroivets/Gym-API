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
        public async Task<IEnumerable<Training>> GetAsync()
        {
            return await _trainingRepository.GetAsync();
        }
        public async Task<Training> GetAsync(int id)
        {
            return await _trainingRepository.GetAsync(id);

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
