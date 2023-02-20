using AutoMapper;
using MoviesApi.Data.DTO;
using MoviesApi.Models;

namespace MoviesApi.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            // Source -> Target
            CreateMap<CreateAddressDTO, Address>();
            CreateMap<Address, ReadAddressDTO>();
            CreateMap<UpdateAddressDTO, Address>();
        }
    }
}