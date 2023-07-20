using AutoMapper;
using PokeReviewApp.Dto;
using PokeReviewApp.Models;

namespace PokeReviewApp.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Poke , PokeDto> ();
        }
    }
}
