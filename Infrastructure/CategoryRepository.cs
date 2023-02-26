using Application.Contract;
using Domains;
using ECommerceDbContext;

namespace Infrastructure
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ECommerce_DbContext context;
        public CategoryRepository(ECommerce_DbContext context)
        {
            this.context = context;
        }

        public List<Category> GetAllCategories()
        {
           return context .Categories.ToList();
        }

        public Category? GetCategoryDetails(int id)
        {
            return context.Categories.FirstOrDefault(c=>c.Id==id);
        }
    }
}
