namespace PokeReviewApp.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string ReviewTitle { get; set; }
        public string ReviewText{ get; set; }
        public int ReviewRate {get; set; }
        public Reviewer Reviewer { get; set; } //1 review has 1 reviewer
        public Poke Poke { get; set; } //1 review has 1 poke
    }
}
