﻿namespace CourseWEB.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Clothes> Clothes { get; set; }
    }
}
