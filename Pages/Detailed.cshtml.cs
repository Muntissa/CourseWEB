using CourseWEB.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CourseWEB.Pages
{
    public class DetailedModel : PageModel
    {
        private readonly ILogger<DetailedModel> _logger;
        public Clothes? Cloth;

        public DetailedModel(ILogger<DetailedModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(int? id)
        {
            if (id == null)
                return;

            using (var context = new Context())
                Cloth = context.Clothes.Where(el => el.Id == id).Include(c => c.Images).Include(c => c.Reviews).FirstOrDefault();
        }

        public void OnPostAuth(string name, string desc, int rating, int? id)
        {
            using (var context = new Context())
            {
                Cloth = context.Clothes.Where(el => el.Id == id).Include(c => c.Images).Include(c => c.Reviews).FirstOrDefault();
                Cloth.Reviews.Add(new Review() { Name = name, Description = desc, Grade = rating, Сloth = Cloth});
                context.SaveChanges();
            }     
        }
    }
}