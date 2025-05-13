namespace Movies.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public IEnumerable<Movie> Movies { get; set; } = new HashSet<Movie>();
    }
}