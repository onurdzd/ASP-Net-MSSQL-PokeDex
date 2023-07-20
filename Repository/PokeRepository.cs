using PokeReviewApp.Data;
using PokeReviewApp.Interfaces;
using PokeReviewApp.Models;

namespace PokeReviewApp.Repository
{
    public class PokeRepository : IPokeRepository
    {
        private readonly DataContext _context;
        public PokeRepository(DataContext context) {
            _context = context;
        }
        public ICollection<Poke>GetPokes() //Dizi içeriği Poke olacak şekilde dönen ve tüm pokeleri bulan method 
        {
            return _context.Pokes.OrderBy(p=>p.PokeId).ToList();
        }

        public Poke GetPoke(int id)
        {
            return _context.Pokes.Where(p => p.PokeId == id).FirstOrDefault();
        }

        public Poke GetPoke(string name)
        {
            return _context.Pokes.Where(p => p.PokeName == name).FirstOrDefault();
        }

        public decimal GetPokeRating(int pokeId)
        {
            var review = _context.Reviews.Where(p => p.Poke.PokeId == pokeId);
            if(review.Count() <= 0)
            {
                return 0;
            }

            return ((decimal)review.Sum(review => review.ReviewRate) / review.Count());
        }


        public bool IsPokeExist(int pokeId)
        {
            return _context.Pokes.Any(p => p.PokeId == pokeId);
        }

        public bool IsPokeExist(string pokeName)
        {
            return _context.Pokes.Any(p => p.PokeName == pokeName);
        }
    }
}
