namespace Movies.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public ICollection<ActorMovie> ActorMovies { get; set; }
    }
}