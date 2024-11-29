using KooliProjekt.Data;
using KooliProjekt.Search;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public TodoListService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Delete(int id)
        {
            await _context.Product
                .Where(list => list.Id == id)
                .ExecuteDeleteAsync();
        }

        public async Task<Product> Get(int id)
        {
            return await _context.Product.FindAsync(id);
        }

        public async Task<PagedResult<Product>> List(int page, int pageSize, ProductSearch search = null)
        {
            var query = _context.Product.AsQueryable();

            search = search ?? new ProductSearch();

            if (!string.IsNullOrWhiteSpace(search.Keyword))
            {
                query = query.Where(list => list.Title.Contains(search.Keyword));
            }

            if (search.Done != null)
            {
                query = query.Where(list => list.Items.Any());

                if (search.Done.Value)
                {
                    query = query.Where(list => list.Items.All(item => item.IsDone));
                }
                else
                {
                    query = query.Where(list => list.Items.Any(item => !item.IsDone));
                }
            }

            return await query
                .OrderBy(list => list.Title)
                .GetPagedAsync(page, pageSize);
        }

        public async Task Save(Product list)
        {
            if (list.Id == 0)
            {
                _context.Product.Add(list);
            }
            else
            {
                _context.Product.Update(list);
            }

            await _context.SaveChangesAsync();
        }
    }
}