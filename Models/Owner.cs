namespace PokeReviewApp.Models
{
    public class Owner
    {
        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string OwnerLastName { get; set; }
        public string OwnerGym { get; set; }
        public Country Country { get; set; } //1 owner has 1 country
        public ICollection<PokeOwner>PokeOwners { get; set; } //many to manyden gelen
    }
}
