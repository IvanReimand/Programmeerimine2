using KooliProjekt.Data;
using KooliProjekt.Search;

namespace KooliProjekt.Models
{
    public class ProductCategoryIndexModel
    {
        public ProductCategorySearch Search { get; set; }
        public PagedResult<ProductCategory> Data { get; set; }
    }
}
