using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Data.DTO
{
    public class UpdateCineDTO
    {
        [Required(ErrorMessage = "O nome do cinema é obrigatório")]
        public string name {get;set;}
    }
}