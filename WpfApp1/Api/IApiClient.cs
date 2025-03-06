namespace KooliProjekt.WpfApp.Api
{
    public interface IApiClient
    {
        Task<IList<Order>> List();
        Task Save(Order list);
        Task Delete(int id);
    }
}