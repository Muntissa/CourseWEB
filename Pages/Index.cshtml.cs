using CourseWEB.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CourseWEB.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public int Counter = 1;
        public int Counter2 = 1;
        public List<Clothes> Categories = new List<Clothes>();
        public int? CategoryId = null;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(int? category_id)
        {
            if (category_id == null) Categories = LoadClothes(category_id);
            CategoryId = category_id;
        }

        public List<Clothes> LoadClothes(int? category_id)
        {
            using (var context = new Context())
                return context.Clothes.Where(el => el.Category.Id == CategoryId).Include(c => c.Images).ToList();
        }

        public List<Category> LoadCategory()
        {
            using(var context = new Context())
                return context.Categories.ToList();
        }

    }
}