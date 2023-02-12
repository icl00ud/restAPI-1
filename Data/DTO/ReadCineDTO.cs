using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Data.DTO
{
    public class ReadCineDTO
    {
        public int id{get;set;}
        [Required(ErrorMessage = "O nome do cinema é obrigatório")]
        public string name {get;set;}
    }
}