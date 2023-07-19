using PokeReviewApp.Data;
using PokeReviewApp.Models;

namespace PokeReviewApp
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if (!dataContext.PokeOwners.Any())
            {
                var PokeOwners = new List<PokeOwner>()
                {
                    new PokeOwner()
                    {
                        Poke = new Poke()
                        {
                            PokeName = "Pikachu",
                            PokeBDate = new DateTime(1903,1,1),
                            PokeCategories = new List<PokeCategory>()
                            {
                                new PokeCategory { Category = new Category() { CategoryName = "Electric"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { ReviewTitle="Pikachu",ReviewText = "Pickahu is the best Poke, because it is electric", ReviewRate = 5,
                                Reviewer = new Reviewer(){ ReviewerName = "Teddy", ReviewerLastName = "Smith" } },
                                new Review { ReviewTitle="Pikachu", ReviewText = "Pickachu is the best a killing rocks", ReviewRate = 5,
                                Reviewer = new Reviewer(){ ReviewerName = "Taylor", ReviewerLastName = "Jones" } },
                                new Review { ReviewTitle="Pikachu",ReviewText = "Pickchu, pickachu, pikachu", ReviewRate = 1,
                                Reviewer = new Reviewer(){ ReviewerName = "Jessica", ReviewerLastName = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            OwnerName = "Jack",
                            OwnerLastName = "London",
                            OwnerGym = "Brocks Gym",
                            Country = new Country()
                            {
                                CountryName = "Kanto"
                            }
                        }
                    },
                    new PokeOwner()
                    {
                        Poke = new Poke()
                        {
                            PokeName = "Squirtle",
                            PokeBDate = new DateTime(1903,1,1),
                            PokeCategories = new List<PokeCategory>()
                            {
                                new PokeCategory { Category = new Category() { CategoryName = "Water"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { ReviewTitle= "Squirtle", ReviewText = "squirtle is the best Poke, because it is electric", ReviewRate = 5,
                                Reviewer = new Reviewer(){ ReviewerName = "Teddy", ReviewerLastName = "Smith" } },
                                new Review { ReviewTitle= "Squirtle",ReviewText = "Squirtle is the best a killing rocks", ReviewRate = 5,
                                Reviewer = new Reviewer(){ ReviewerName = "Taylor", ReviewerLastName = "Jones" } },
                                new Review { ReviewTitle= "Squirtle", ReviewText = "squirtle, squirtle, squirtle", ReviewRate = 1,
                                Reviewer = new Reviewer(){ ReviewerName = "Jessica", ReviewerLastName = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            OwnerName = "Harry",
                            OwnerLastName = "Potter",
                            OwnerGym = "Mistys Gym",
                            Country = new Country()
                            {
                                CountryName = "Saffron City"
                            }
                        }
                    },
                                    new PokeOwner()
                    {
                        Poke = new Poke()
                        {
                            PokeName = "Venasuar",
                            PokeBDate = new DateTime(1903,1,1),
                            PokeCategories = new List<PokeCategory>()
                            {
                                new PokeCategory { Category = new Category() { CategoryName = "Leaf"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { ReviewTitle="Veasaur",ReviewText = "Venasuar is the best Poke, because it is electric", ReviewRate = 5,
                                Reviewer = new Reviewer(){ ReviewerName = "Teddy", ReviewerLastName = "Smith" } },
                                new Review { ReviewTitle="Veasaur",ReviewText = "Venasuar is the best a killing rocks", ReviewRate = 5,
                                Reviewer = new Reviewer(){ ReviewerName = "Taylor", ReviewerLastName = "Jones" } },
                                new Review { ReviewTitle="Veasaur",ReviewText = "Venasuar, Venasuar, Venasuar", ReviewRate = 1,
                                Reviewer = new Reviewer(){ ReviewerName = "Jessica", ReviewerLastName = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            OwnerName = "Ash",
                            OwnerLastName = "Ketchum",
                            OwnerGym = "Ashs Gym",
                            Country = new Country()
                            {
                                CountryName = "Millet Town"
                            }
                        }
                    }
                };
                dataContext.PokeOwners.AddRange(PokeOwners);
                dataContext.SaveChanges();
            }
        }
    }
}