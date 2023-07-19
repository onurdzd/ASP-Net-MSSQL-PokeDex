namespace PokeReviewApp.Models
{
    public class Poke
    {
        public int PokeId { get; set; }
        public string PokeName { get; set; }
        public DateTime PokeBDate { get; set; }
        public ICollection<Review> Reviews { get; set;} //1 to many 1 poke has many reviews
        public ICollection<PokeOwner> PokeOwners { get; set; } //many to manyden gelen
        public ICollection<PokeCategory> PokeCategories { get; set; } //many to manyden gelen
    }
}
