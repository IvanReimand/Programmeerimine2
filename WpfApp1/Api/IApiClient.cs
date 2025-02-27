
namespace Kooliprojekt.WpfApp1.Api
{
    public interface IApiClient
    {
        Task<IList<Order>> List();
    }
}