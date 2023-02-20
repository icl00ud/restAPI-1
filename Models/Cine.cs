using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Models
{
    public class Cine
    {
        [Key]
        [Required]
        public int id {get;set;}
        [Required(ErrorMessage = "O nome do cinema é obrigatório")]
        public string name {get;set;}
        public int addressId {get;set;}
        public virtual Address address {get;set;}
    }
}