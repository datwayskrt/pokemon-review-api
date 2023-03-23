using AutoMapper;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Model;

namespace PokemonReviewApp.Helper
{
    public class MappingProfiles : Profile
    {
            public MappingProfiles()
            {
                CreateMap<Pokemon, PokemonDto>();
                CreateMap<Country, CountryDto>();
                CreateMap<Category, CategoryDto>();

            }
    }
       
    
}
