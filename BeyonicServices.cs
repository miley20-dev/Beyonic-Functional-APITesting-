using Beyonic.Services.ResponseViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Beyonic.Services
{
    public class BeyonicServices
    {
       public async Task<ResponseViewModel> GetCurrencies()
        {
            try
            {
                var url = new Uri("https://api.beyonic.com/api/currencies");
                using var client = new HttpClient();
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Token", "ab594c14986612f6167a975e1c369e71edab6900");
                var response = await client.GetAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }
                return  JsonConvert.DeserializeObject<ResponseViewModel>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public async Task<object> GetNetworks()
        {
            try
            {
                var url = new Uri("https://api.beyonic.com/api/networks");
                using var client = new HttpClient();
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Token", "ab594c14986612f6167a975e1c369e71edab6900");
                var response = await client.GetAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }
                return JsonConvert.DeserializeObject<object>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

    }
}
