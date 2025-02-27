using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;


namespace Kooliprojekt.WpfApp1.Api
{
    public class Get : IApiClient
    {
        private readonly HttpClient _httpClient;

        public Get()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
        }
        public async Task List()
        {
            var url = "Order";
            var x = await _httpClient.GetFromJsonAsync<List<Order>>(url);
        }
        public async Task Save(Order list)
        {
            var url = "Order";
            if (list.Id == 0)
            {
                await _httpClient.PostAsJsonAsync(url, list);
            }
            else
            {
                url += "/" + list.Id;
                await _httpClient.PutAsJsonAsync(url, list);
            }
        }
        public async Task Delete private Get(int id)
        {
            var url = "Order";
        }
    }
}