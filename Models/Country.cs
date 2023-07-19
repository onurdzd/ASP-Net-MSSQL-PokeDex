namespace PokeReviewApp.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public ICollection<Owner> Owners { get; set;} //1 to many 1 country have many owner
    }
}
