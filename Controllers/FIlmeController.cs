using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.COntrollers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>;

    public void AddFilme(Filme filme)
    {
        filmes.add(filme);
    }
}