using Microsoft.EntityFrameworkCore;
namespace LibraryAPIWebAppLab2.Models
{
    public class LibraryAPIContext: DbContext
    {
        
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Distributor> Distributors { get; set; }
        public virtual DbSet<Producer> Producers { get; set; }
        public virtual DbSet<ProducerFilm> ProducerFilms { get; set; }
        public LibraryAPIContext(DbContextOptions<LibraryAPIContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
