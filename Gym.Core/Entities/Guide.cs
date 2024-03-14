namespace gym_rutiKroivets.Entities
{
    public class Guide
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Seniority { get; set; }
        public List<Training> Trainings { get; set; }
    }
}
