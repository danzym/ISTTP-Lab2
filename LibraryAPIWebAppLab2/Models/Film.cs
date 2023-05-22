using System.ComponentModel.DataAnnotations;
namespace LibraryAPIWebAppLab2.Models
{
    public class Film
    {
        public Film()
        {
            ProducerFilm = new List<ProducerFilm>();
        }
        public int Id { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        [Display(Name = "Description")]
        public string Description { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Distributor Distributor { get; set; }
        public virtual ICollection<ProducerFilm> ProducerFilm { get; set; }
    }
}
