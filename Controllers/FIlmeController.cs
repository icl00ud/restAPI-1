using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.COntrollers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();
    private static int id = 0;

    [HttpPost]
    public void AddFilme([FromBody] Filme filme)
    {
        filme.id = id++;
        filmes.Add(filme);
    }

    [HttpGet]
    public IEnumerable<Filme> GetFilmes()
    {
        return filmes;
    }
}