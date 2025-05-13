namespace Movies.Models
{
    public class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; }
        = null!;
        public string Description { get; set; } = null!;
        public string Address { get; set; } = null!;

        public IEnumerable<Movie> Movies = new HashSet<Movie>();

    }
}