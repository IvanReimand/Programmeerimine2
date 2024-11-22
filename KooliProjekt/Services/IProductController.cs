using KooliProjekt.Data;

namespace KooliProjekt.Services
{
    public interface IProductategoryService
    {
        Task<PagedResult<ProductCategoriesService>> List(int page, int pageSize);
        Task<ProductCategoriesService> Get(int id);
        Task Save(ProductCategory list);
        Task Delete(int id);
    }
}