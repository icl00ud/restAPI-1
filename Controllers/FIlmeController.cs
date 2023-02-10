using MoviesApi.Models;
using Microsoft.AspNetCore.Mvc;
using MoviesApi.Data;
using MoviesApi.Data.DTO;
using AutoMapper;

namespace moviesApi.COntrollers;

[ApiController]
[Route("[controller]")]
public class MovieController : ControllerBase
{

    private MovieContext _context;
    private IMapper _mapper;

    public MovieController(MovieContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AddFilme([FromBody] CreateMovieDTO movieDTO)
    {
        Movie movie = _mapper.Map<Movie>(movieDTO);
        _context.Movies.Add(movie);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetMoviesById), new {id = movie.id}, movie);
    }

    [HttpGet]
    public IEnumerable<Movie> Getmovies([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _context.Movies.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult GetMoviesById(int id)
    {
        var movie = _context.Movies.FirstOrDefault(filme => filme.id == id);
        if(movie == null) return NotFound();
        return Ok(movie);
    } 
}