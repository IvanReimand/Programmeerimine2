using KooliProjekt.WinFormsApp.Api;

namespace KooliProjekt.WinFormsApp
{
    public class OrderPresenter
    {
        private readonly IApiClient _apiClient;
        private readonly IOrderView _orderView;

        public OrderPresenter(IOrderView orderView, IApiClient apiClient)
        {
            _apiClient = apiClient;
            _orderView = orderView;

            orderView.Presenter = this;
        }

        public void UpdateView(Order list)
        {
            if (list == null)
            {
                _orderView.Title = string.Empty;
                _orderView.Id = 0;
            }
            else
            {
                _orderView.Id = list.Id;
                _orderView.Title = list.Title;
            }
        }

        public async Task Load()
        {
            var orderLists = await _apiClient.List();

            _orderView.Order = order.Value;
        }
    }
}