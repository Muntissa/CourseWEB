using Microsoft.AspNetCore.Mvc;
using CourseWEB.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CourseWEB.Pages
{
    public class NewsDetailedModel : PageModel
    {
        private readonly ILogger<NewsDetailedModel> _logger;
        public News? news;

        public NewsDetailedModel(ILogger<NewsDetailedModel> logger)
        {
            _logger = logger;
        }
        public void OnGet(int? id)
        {
            if (id == null)
                return;

            using (var context = new Context())
                news = context.News.Where(el => el.Id == id).Include(c => c.Images).FirstOrDefault();
        }
    }
}
