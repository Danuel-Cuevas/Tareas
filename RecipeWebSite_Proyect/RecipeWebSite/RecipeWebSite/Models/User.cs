namespace RecipeWebSite.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public ICollection<Recipe> Recetas { get; set; } = new List<Recipe>();
        public ICollection<Commentary> Comentarios { get; set; } = new List<Commentary>();
        public ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();

        public override string ToString()
        {
            return $"User: {Name} - {Email}";
        }
    }
}
