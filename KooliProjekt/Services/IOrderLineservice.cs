using KooliProjekt.Data;

namespace KooliProjekt.Services
{
    public interface IOrderLineService
    {
        Task<PagedResult<OrderLine>> List(int page, int pageSize);
        Task<OrderLine> Get(int id);
        Task Save(OrderLine list);
        Task Delete(int id);
    }
}