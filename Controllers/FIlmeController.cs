using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.COntrollers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();

    [HttpPost]
    public void AddFilme([FromBody] Filme filme)
    {
        filmes.Add(filme);
        Console.WriteLine(filme.titulo);
        Console.WriteLine(filme.genero);
        Console.WriteLine(filme.duracao);
    }
}