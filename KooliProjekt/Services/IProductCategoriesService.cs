using KooliProjekt.Data;

namespace KooliProjekt.Services
{
    public interface IProductcategoryService
    {
        Task<PagedResult<ProductCategory>> List(int page, int pageSize);
        Task<ProductCategory> Get(int id);
        Task Save(ProductCategory category);
        Task Delete(int id);
    }
}