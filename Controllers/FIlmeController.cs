using MoviesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace moviesApi.COntrollers;

[ApiController]
[Route("[controller]")]
public class MovieController : ControllerBase
{
    private static List<Movie> movies = new List<Movie>();
    private static int id = 0;

    [HttpPost]
    public IActionResult AddFilme([FromBody] Movie movie)
    {
        movie.id = id++;
        movies.Add(movie);
        return CreatedAtAction(nameof(GetMoviesById), new {id = movie.id}, movie);
    }

    [HttpGet]
    public IEnumerable<Movie> Getmovies([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return movies.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult GetMoviesById(int id)
    {
        movies.FirstOrDefault(filme => filme.id == id);
        if(movies == null) return NotFound();
        return Ok(movies);
    } 
}