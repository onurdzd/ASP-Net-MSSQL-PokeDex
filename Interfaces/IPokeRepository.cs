using PokeReviewApp.Models;

namespace PokeReviewApp.Interfaces
{
    public interface IPokeRepository
    {
        ICollection<Poke> GetPokes();
        Poke GetPoke(int pokeId);
        Poke GetPoke(string name);
        decimal GetPokeRating(int pokeId);
        bool IsPokeExist(int pokeId);
        //bool IsPokeExist(string pokeName);

    }
}
