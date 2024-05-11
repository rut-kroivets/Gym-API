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
    public class TrainingRepository:ITrainingRepository
    {
        private readonly DataContext _dataContext;
        public TrainingRepository(DataContext context)
        {
            _dataContext = context;
        }
     
        public async Task<IEnumerable<Training>> GetAsync()
        {
            return await _dataContext.trainings.ToListAsync();
        }
        
        public async Task<Training> GetAsync(int id)
        {
            return await _dataContext.trainings.FindAsync(id);          
        }

       
        public async Task<Training> PostAsync(Training t)
        {
            _dataContext.trainings.Add(t);
            await _dataContext.SaveChangesAsync();
            return t;
        }
        public async Task PutAsync(int id, Training t)
        {
            var train = _dataContext.trainings.Find(id);
            train.Title = t.Title;
            train.Day = t.Day;
            train.Hour = t.Hour;
            await _dataContext.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var train = _dataContext.trainings.Find(id);
            _dataContext.trainings.Remove(train);
            await _dataContext.SaveChangesAsync();
        }
    }
}
