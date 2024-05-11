using gym_rutiKroivets.Entities;

using gym_rutiKroivets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Gym.Core.Repository;
using Microsoft.EntityFrameworkCore;

namespace Gym.Data.Repository
{
    public class GuideRepository:IGuideRepository
    {
        private readonly DataContext _dataContext;
        public GuideRepository(DataContext context)
        {
            _dataContext = context;
        }      
        public async Task<IEnumerable<Guide>> GetAsync()
        {
             return await _dataContext.guides.ToListAsync(); ;
        }
        public async Task<Guide> GetAsync(int id)
        {
            return await _dataContext.guides.FindAsync(id);
        }
        public async Task<Guide> PostAsync(Guide g)
        {
            _dataContext.guides.Add(g);
            await _dataContext.SaveChangesAsync();
            return g;
        }
        public async Task PutAsync(int id, Guide g)
        {
            var guide = _dataContext.guides.Find( id);
            guide.Name = g.Name;
            guide.Address = g.Address;
            guide.Seniority = g.Seniority;
            await _dataContext.SaveChangesAsync();
            
        }
        public async Task DeleteAsync(int id)
        {
            var guide = _dataContext.guides.Find(id);
            _dataContext.guides.Remove(guide);
            await _dataContext.SaveChangesAsync();
        }
    }
}
