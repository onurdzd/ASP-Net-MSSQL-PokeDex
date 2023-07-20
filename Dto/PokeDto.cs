namespace PokeReviewApp.Dto
{
    public class PokeDto
    {
        //api req den dönen reslerin içeriğini ayarlamak için. sensitive data varsa göstertmeyecek
        public int PokeId { get; set; }
        public string PokeName { get; set; }
        public DateTime PokeBDate { get; set; }
    }
}
