using KooliProjekt.Data;
using KooliProjekt.Search;

namespace KooliProjekt.Models
{
    public class ProductCategoriesIndexModel
    {
        public ProductCategoriesSearch Search { get; set; }
        public PagedResult<ProductCategory> Data { get; set; }
    }
}
