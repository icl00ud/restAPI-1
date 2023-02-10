using System;

namespace MoviesApi.Data.DTO
{
    public class ReadMovieDTO
    {
        public string title {get;set;}
        public string gender {get;set;}
        public int duration {get;set;}
        public DateTime consultedHour {get;set;} = DateTime.Now;
    }
}