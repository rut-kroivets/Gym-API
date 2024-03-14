using gym_rutiKroivets.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Core.DTOs
{
    public class TrainingDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Day { get; set; }
        public double Hour { get; set; }
        public Guide Guid { get; set; }
    }
}
