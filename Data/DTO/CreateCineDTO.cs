using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Data.DTO
{
    public class CreateCineDTO
    {
        [Required(ErrorMessage = "O nome do cinema é obrigatório")]
        public string name {get;set;}
        public int addressId {get;set;}
    }
}