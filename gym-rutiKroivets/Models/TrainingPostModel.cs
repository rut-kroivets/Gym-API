using gym_rutiKroivets.Entities;

namespace gym_rutiKroivets.Models
{
    public class TrainingPostModel
    {
        public string Title { get; set; }
        public int Day { get; set; }
        public double Hour { get; set; }
        public Guide Guid { get; set; }
    }
}
