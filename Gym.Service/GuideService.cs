using Gym.Core.Repository;
using Gym.Core.Service;
using gym_rutiKroivets;
using gym_rutiKroivets.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Service
{
    public class GuideService: IGuideService
    {
        private readonly IGuideRepository _guideRepository;
        public GuideService(IGuideRepository context1)
        {
            _guideRepository = context1;
        }
        public async Task<IEnumerable<Guide>> GetAsync()
        {
            return await _guideRepository.GetAsync();
        }

        public async Task<Guide> GetAsync(int id)
        {
            return await _guideRepository.GetAsync(id);
        }

        public async Task<Guide> PostAsync(Guide g)
        {
            return await _guideRepository.PostAsync(g);
        }

        public async Task PutAsync(int id, Guide g)
        {
             await _guideRepository.PutAsync(id, g);
        }

        public async Task DeleteAsync(int id)
        {
             await  _guideRepository.DeleteAsync(id);
        }
    }
}
