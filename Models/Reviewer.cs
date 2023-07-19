namespace PokeReviewApp.Models
{
    public class Reviewer
    {
        public int ReviewerId { get; set; }
        public string ReviewerName { get; set; }
        public string ReviewerLastName { get; set; }
        public ICollection<Review> Reviews { get; set;} //1 Reviewer has multiple Review
    }
}
