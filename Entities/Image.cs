namespace CourseWEB.Entities
{
    public class Image
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public Clothes? Cloth { get; set; }
        public News? News { get; set; }
    }
}
