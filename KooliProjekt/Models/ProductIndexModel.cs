using KooliProjekt.Data;
using KooliProjekt.Search;

namespace KooliProjekt.Models
{
    public class ProductIndexModel
    {
        public ProductSearch Search { get; set; }
        public PagedResult<Product> Data { get; set; }
    }
}