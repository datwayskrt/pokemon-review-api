using PokemonReviewApp.Model;

namespace PokemonReviewApp.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        ICollection<Pokemon> GetPokemonByCategory(int CategoryId);
        bool CategoryExists(int id);
        bool CreateCategory(Category category);
        bool Save();
        bool UpdateCategory(Category category);
    }
}
