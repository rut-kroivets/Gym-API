namespace gym_rutiKroivets.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public List<Training> Trainings { get; set; }

    }
}
