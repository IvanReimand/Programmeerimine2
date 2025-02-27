using System.Collections.ObjectModel;
using Kooliprojekt.WpfApp1.Api;

namespace Koliprojekt.WpfApp1
{
    public class MainWindowViewModel
    {
        private readonly IApiClient _apiClient;
        private IEnumerable<object> lists;

        public ObservableCollection<Order> List { get; set; } // Fixed accessor issue
        public MainWindowViewModel(IApiClient apiClient)
        {
            _apiClient = apiClient;
            List = new ObservableCollection<Order>();
        }
        public async Task<IList<Order>> Load()
        {
            var list = await _apiClient.List();
            foreach (var list in lists)
            {
                List.Add((Order)list);
            }
        }
        private Order _selectedItem;
        private Order SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                _selectedItem = value;
                                               
            }
        }
    }
}