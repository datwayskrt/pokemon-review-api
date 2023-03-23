using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Model;

namespace PokemonReviewApp.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private DataContext _context;
        public CategoryRepository(DataContext context) 
        {
            _context = context;
        }
        public bool CategoryExists(int id)
        {
            return _context.Categories.Any(c => c.Id == id);
        }
        public ICollection<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }
        public Category GetCategory(int id)
        {
            return _context.Categories.Where(c => c.Id == id).FirstOrDefault();
        }

        public ICollection<Pokemon> GetPokemonByCategory(int CategoryId)
        {
            return _context.PokemonCategories.Where(p => p.CategoryId == CategoryId).Select(c => c.Pokemon).ToList();
        }
    }
}
