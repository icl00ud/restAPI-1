using MoviesApi.Models;
using Microsoft.AspNetCore.Mvc;
using MoviesApi.Data;
using MoviesApi.Data.DTO;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;

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
        var movie = _mapper.Map<Movie>(movieDTO);
        _context.Movies.Add(movie);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetMoviesById), new {id = movie.id}, movie);
    }

    [HttpGet]
    public IEnumerable<ReadMovieDTO> GetMovies([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _mapper.Map<List<ReadMovieDTO>>(_context.Movies.Skip(skip).Take(take));
    }

    [HttpGet("{id}")]
    public IActionResult GetMoviesById(int id)
    {
        var movie = _context.Movies.FirstOrDefault(filme => filme.id == id);
        if(movie == null) return NotFound();
        var movieDTO = _mapper.Map<ReadMovieDTO>(movie);
        return Ok(movieDTO);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateMovie(int id, [FromBody] UpdateMovieDTO movieDTO)
    {
        var movie = _context.Movies.FirstOrDefault(movie => movie.id == id);
        if(movie == null) return NotFound();
        _mapper.Map(movieDTO, movie);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpPatch("{id}")]
    public IActionResult UpdateMovie(int id, JsonPatchDocument<UpdateMovieDTO> patch)
    {
        var movie = _context.Movies.FirstOrDefault(movie => movie.id == id);
        if(movie == null) return NotFound();

        var movieToUpdate = _mapper.Map<UpdateMovieDTO>(movie);

        patch.ApplyTo(movieToUpdate, ModelState);
        if(!TryValidateModel(movieToUpdate))
        {
            return ValidationProblem(ModelState);
        }

        _mapper.Map(movieToUpdate, movie);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteMovie(int id)
    {
        var movie = _context.Movies.FirstOrDefault(movie => movie.id == id);
        if(movie == null) return NotFound();
        _context.Remove(movie);
        _context.SaveChanges();
        return NoContent();
    }
}