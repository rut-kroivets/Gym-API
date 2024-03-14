namespace gym_rutiKroivets.Entities
{
    public class Training
    {
        public int Id { get; set; }
        public string  Title { get; set; }
        public int Day { get; set; }
        public double Hour { get; set; }
        public Guide Guid { get; set; }
        public List<Student> Students { get; set; }

    }
}
