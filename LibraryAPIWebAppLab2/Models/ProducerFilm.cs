namespace LibraryAPIWebAppLab2.Models
{
    public class ProducerFilm
    {
        public int Id { get; set; }
        public int ProducerId { get; set; }
        public int FilmId { get; set; }
        public virtual Producer Producer { get; set; }
        public virtual Film Film { get; set; }
    }
}
