using CourseWEB.Entities;
using Microsoft.EntityFrameworkCore;

namespace CourseWEB
{
    public class Context : DbContext
    {
        /// <summary>
        /// Инициализация табличек
        /// </summary>
        public DbSet<Clothes> Clothes { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<News> News { get; set; }


        /// <summary>
        /// Проверка валидности базы данных
        /// </summary>
        public Context()
        {
            Database.EnsureCreated();
        }

        /// <summary>
        /// Конфигурием подключение к бд
        /// </summary>
        /// <param name="optionsBuilder">Определение конфигурации</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=myDb.db");
        }
    }
}
