using AutoMapper;
using MoviesApi.Data.DTO;
using MoviesApi.Models;

namespace MoviesApi.Profiles
{
    public class CineProfile : Profile
    {
        public CineProfile()
        {
            CreateMap<CreateCineDTO, Cine>();
            CreateMap<Cine, ReadCineDTO>();
            CreateMap<UpdateCineDTO, Cine>();
        }
    }
}