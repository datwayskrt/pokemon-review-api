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
                CreateMap<CountryDto, Country>();

                CreateMap<Category, CategoryDto>();
                CreateMap<CategoryDto, Category>();

                CreateMap<Owner, OwnerDto>();

                CreateMap<Review, ReviewDto>();  
                CreateMap<ReviewDto, Review>();

                CreateMap<Reviewer, ReviewerDto>();
                CreateMap<ReviewerDto, Reviewer>();

            }
    }
       
    
}
