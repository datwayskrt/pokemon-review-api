using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Model;

namespace PokemonReviewApp.Interfaces
{
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();
        Country GetCountry(int id);
        Country GetCountryByOwner(int ownerId);
        ICollection<Owner> GetOwnersFromACountry(int countryId);
        bool CountryExists(int id);

        bool UpdateCountry(Country country);
        bool Save();
    }
}
