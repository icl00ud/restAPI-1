using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Models
{
    public class Address
    {
        [Key]
        [Required]
        public int id {get;set;}
        public string street {get;set;}
        public int number {get;set;}
        public virtual Cine cine {get;set;}
    }
}