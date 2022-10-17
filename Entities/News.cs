namespace CourseWEB.Entities
{
    public class News
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDecription { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public List<Image> Images { get; set; }
    }
}
