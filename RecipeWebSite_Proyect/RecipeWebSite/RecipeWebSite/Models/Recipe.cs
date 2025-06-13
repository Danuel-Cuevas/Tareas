namespace RecipeWebSite.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public ICollection<Commentary> Comentarios { get; set; } = new List<Commentary>();
        public ICollection<Favorite> Favoritos { get; set; } = new List<Favorite>();
    }
}
