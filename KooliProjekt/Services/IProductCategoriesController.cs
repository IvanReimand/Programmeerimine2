using KooliProjekt.Data;

namespace KooliProjekt.Services
{
    public interface IProductcategoryService
    {
        Task<PagedResult<ProductCategoriesController>> List(int page, int pageSize);
        Task<ProductCategoriesController> Get(int id);
        Task Save(ProductCategoriesController list);
        Task Delete(int id);
    }
}