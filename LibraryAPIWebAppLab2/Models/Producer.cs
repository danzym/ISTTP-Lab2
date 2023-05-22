using System.ComponentModel.DataAnnotations;
namespace LibraryAPIWebAppLab2.Models
{
    public class Producer
    {
        public Producer()
        {
            ProducerFilm = new List<ProducerFilm>();
        }
        public int Id { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Field cannot be empty")]
        [Display(Name = "Description")]
        public string Description { get; set; }
        public virtual ICollection<ProducerFilm> ProducerFilm { get; set;}
    }
}
