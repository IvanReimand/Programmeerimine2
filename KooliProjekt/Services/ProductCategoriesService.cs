using KooliProjekt.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Services
{
    public class ProductCategoriesService : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductCategoriesService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PagedResult<ProductCategory>> List(int page, int pageSize)
        {
            return await _context.ProductCategory.GetPagedAsync(page, 5);
        }

        public async Task<ProductCategory> Get(int id)
        {
            return await _context.ProductCategory.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task Save(ProductCategory list)
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
            var category = await _context.ProductCategory.FindAsync(id);
            if (category != null)
            {
                _context.ProductCategory.Remove(category);
                await _context.SaveChangesAsync();
            }
        }
    }
}