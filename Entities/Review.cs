namespace CourseWEB.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Grade { get; set; }
        public Clothes Сloth { get; set; }
    }
}
