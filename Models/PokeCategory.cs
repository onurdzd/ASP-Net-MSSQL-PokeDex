namespace PokeReviewApp.Models
{
    public class PokeCategory
    {
        public int PokeId { get; set; }
        public int CategoryId { get; set; }
        public Poke Poke { get; set; }
        public Category Category { get; set; }
    }
   
}
