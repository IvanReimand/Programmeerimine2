using KooliProjekt.Data;

namespace KooliProjekt.Services
{
    public class ProductCategoriesController : IProductCategory
    {
        private readonly ApplicationDbContext _context;

        public ProductCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PagedResult<ProductCategoriesController>> List(int page, int pageSize)
        {
            return await _context.ProductCategory.GetPagedAsync(page, 5);
        }

        public async Task<Product> Get(int id)
        {
            return await _context.Product.Include(o => o.User).FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task Save(Product list)
        {
            if (list.Id == 0)
            {
                _context.Add(list);
            }
            else
            {
                _context.Update(list);
            }

            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var todoList = await _context.Order.FindAsync(id);
            if (todoList != null)
            {
                _context.Order.Remove(todoList);
                await _context.SaveChangesAsync();
            }
        }
    }
}