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
            CreateMap<Cine, ReadCineDTO>().ForMember(cineDTO => cineDTO.address, opt => opt.MapFrom(cine => cine.address));
            CreateMap<UpdateCineDTO, Cine>();
        }
    }
}