using CourseWEB.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CourseWEB.Pages
{
    public class NewsModel : PageModel
    {
        private readonly ILogger<NewsModel> _logger;

        public NewsModel(ILogger<NewsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            
        }

        //Как использовать? Загружаем список News
        public List<News> LoadNews()
        {
            using (var context = new Context())
                return context.News.Include(c => c.Images).ToList();
        }
    }
}