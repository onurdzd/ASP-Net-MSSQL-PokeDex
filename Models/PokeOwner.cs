namespace PokeReviewApp.Models
{
    public class PokeOwner
    {
        public int PokeId { get; set; }
        public int OwnerId { get; set; }    
        public Poke Poke { get; set; }
        public Owner Owner { get; set; }    
    }
}
