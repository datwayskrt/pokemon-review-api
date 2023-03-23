using PokemonReviewApp.Data;
using PokemonReviewApp.Model;

namespace PokemonReviewApp.Interfaces
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly DataContext _context;
        public PokemonRepository(DataContext context) 
        { 
            _context = context;
        }

        public ICollection<Pokemon> GetPokemons() 
        { 
            return _context.Pokemon.OrderBy(p => p.Id).ToList();
        }
    }
}
