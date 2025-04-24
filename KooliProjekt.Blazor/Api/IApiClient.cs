using System.Collections.Generic;
using System.Threading.Tasks;

namespace KooliProjekt.BlazorApp
{
    public interface IApiClient
    {
        Task<Result<Order>> Get(int id);
        Task<Result<List<Order>>> List();
        Task<Result> Save(Order list);
        Task Delete(int id);
    }

    public class Result
    {
    }

    public class Order
    {
    }
}