using KooliProjekt.Data;
using KooliProjekt.Search;

namespace KooliProjekt.Models
{
    public class OrderLineIndexModel
    {
        public OrderLineSearch Search { get; set; }
        public PagedResult<OrderLine> Data { get; set; }
    }
}