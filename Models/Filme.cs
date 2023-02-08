using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Filme
{
    public int id {get;set;}
    [Required(ErrorMessage = "O título do filme é obrigatório")]
    public string titulo {get;set;}
    [Required(ErrorMessage = "O gênero do filme é obrigatório")]
    [MaxLength(15, ErrorMessage = "Nome muito grande. Máx de caracteres: 15.")]
    public string genero {get;set;}
    [Required]
    [Range(0, 500, ErrorMessage = "Duração deve ser ter uma duração válida.")]
    public int duracao {get;set;}
    
}