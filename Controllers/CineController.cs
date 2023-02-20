using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MoviesApi.Data;
using MoviesApi.Data.DTO;
using MoviesApi.Models;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CineController : ControllerBase
    {
        private MovieContext _context;
        private IMapper _mapper;

        public CineController(MovieContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpPost]
        public IActionResult AdicionaCinema([FromBody] CreateCineDTO cineDTO)
        {
            Cine cinema = _mapper.Map<Cine>(cineDTO);
            _context.Cines.Add(cinema);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetCinesById), new { Id = cinema.id }, cineDTO);
        }

        [HttpGet]
        public IEnumerable<ReadCineDTO> GetCines()
        {
            return _mapper.Map<List<ReadCineDTO>>(_context.Cines.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetCinesById(int id)
        {
            Cine cine = _context.Cines.FirstOrDefault(cine => cine.id == id);
            if (cine != null)
            {
                ReadCineDTO cineDTO = _mapper.Map<ReadCineDTO>(cine);
                return Ok(cineDTO);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCine(int id, [FromBody] UpdateCineDTO cineDTO)
        {
            Cine cine = _context.Cines.FirstOrDefault(cine => cine.id == id);
            if (cine == null)
            {
                return NotFound();
            }
            _mapper.Map(cineDTO, cine);
            _context.SaveChanges();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteCine(int id)
        {
            Cine cine = _context.Cines.FirstOrDefault(cine => cine.id == id);
            if (cine == null)
            {
                return NotFound();
            }
            _context.Remove(cine);
            _context.SaveChanges();
            return NoContent();
        }

    }
}