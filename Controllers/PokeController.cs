using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokeReviewApp.Data;
using PokeReviewApp.Dto;
using PokeReviewApp.Interfaces;
using PokeReviewApp.Models;

namespace PokeReviewApp.Controllers
{
    [Route("api/[controller]")] //erişim adresi
    [ApiController]
  
    public class PokeController : Controller
    {
        private readonly IPokeRepository _pokeRepository;
        private readonly IMapper _mapper;

        public PokeController(IPokeRepository pokeRepository,IMapper mapper)
        {
            _pokeRepository=pokeRepository;
            _mapper = mapper;
        }

        [HttpGet] //get req atıldığında 
        [ProducesResponseType(200, Type = typeof(IEnumerable<Poke>))]
        public IActionResult GetPoke()
        {
            var pokes = _mapper.Map<List<PokeDto>>(_pokeRepository.GetPokes()); //auto mapper pokedto dan aldığı contructor u buraya uyarlıyor. auto mapper kullanmasan new Poke diyip constructor oluşturup PokeDto içerisindeki gibi her seferinde yeniden class oluşturman gerekecekti.Yani burada _pokerepository den gelen Poke PokeDto ya dönüştürülüyor

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(pokes);
        }

        [HttpGet("{pokeId}")] //pokeId ile get req atıldığında 
        [ProducesResponseType(200, Type = typeof(Poke))]
        [ProducesResponseType(400)]
        public IActionResult GetPoke(int pokeId)
        {
           if(!_pokeRepository.IsPokeExist(pokeId))
            {
                return NotFound();
            }
           var poke=_mapper.Map<PokeDto>(_pokeRepository.GetPoke(pokeId));

           if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(poke);
        }

        /*[HttpGet("{pokeName}")] //pokeName ile get req atıldığında 
        [ProducesResponseType(200, Type = typeof(Poke))]
        [ProducesResponseType(400)]
        public IActionResult GetPoke(string pokeName)
        {
            if (!_pokeRepository.IsPokeExist(pokeName))
            {
                return NotFound();
            }

            var poke = _pokeRepository.GetPoke(pokeName);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(poke);
        }*/

        [HttpGet("{pokeId}/rating")]
        [ProducesResponseType(200, Type = typeof(decimal))]
        [ProducesResponseType(400)]

        public IActionResult GetPokeRating(int pokeId)
        {
            if (!_pokeRepository.IsPokeExist(pokeId))
            {
                return NotFound();
            }

            var rating=_pokeRepository.GetPokeRating(pokeId);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(rating);
        }

    }
}
