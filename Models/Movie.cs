using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Models;

public class Movie
{
    [Key]
    [Required]
    public int id {get;set;}
    [Required(ErrorMessage = "O título do filme é obrigatório")]
    public string title {get;set;}
    [Required(ErrorMessage = "O gênero do filme é obrigatório")]
    [StringLength(15, ErrorMessage = "Nome muito grande. Máx de caracteres: 15.")]
    public string gender {get;set;}
    [Required]
    [Range(0, 500, ErrorMessage = "Duração deve ser ter uma duração válida.")]
    public int duration {get;set;}
    
}