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
                CreateMap<PokemonDto, Pokemon>();
                CreateMap<Country, CountryDto>();
                CreateMap<Category, CategoryDto>();
                CreateMap<Owner, OwnerDto>();
                CreateMap<Review, ReviewDto>();   
                CreateMap<Reviewer, ReviewerDto>();

            }
    }
       
    
}
