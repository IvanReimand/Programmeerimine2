using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private readonly HttpClient _httpClient;
        private object txtResponse;

        public MainWindow()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
        }

        // Обработчик клика по кнопке
        private async void btnFetchData_Click(object sender, RoutedEventArgs e)
        {
            // URL для API
            string apiUrl = "https://jsonplaceholder.typicode.com/posts/1";

            try
            {
                // Получаем данные из API
                string response = await FetchDataFromApiAsync(apiUrl);
                txtResponse.Text = response; // Показываем ответ в TextBox
            }
            catch (Exception ex)
            {
                txtResponse.Text = "Error: " + ex.Message;
            }
        }

        // Асинхронный метод для получения данных из API
        private async Task<string> FetchDataFromApiAsync(string url)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode(); // Бросит исключение, если код ответа не 2xx

            string responseData = await response.Content.ReadAsStringAsync();
            return responseData;
        }
    }
}