using System.ComponentModel.DataAnnotations;
namespace LibraryAPIWebAppLab2.Models
{
    public class Genre
    {
        public Genre()
        {
            Films = new List<Film>();
        }
        public int Id { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        [Display(Name = "Genre")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        public virtual ICollection<Film> Films { get; set; }
    }
}
