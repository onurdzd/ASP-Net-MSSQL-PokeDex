namespace PokeReviewApp.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<PokeCategory> PokeCategories { get; set; } //many to manyden gelen

    }
}
