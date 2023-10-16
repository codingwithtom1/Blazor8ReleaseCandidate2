using RC2Demo.Shared;
using System.Net.Http.Json;

namespace RC2Demo.Client.Services
{
    public class APIClientWASM : IAPIClient
    {
        private readonly HttpClient _client;
        public APIClientWASM(HttpClient client)
        {
            _client = client;

        }

        public async Task<List<CustomerDTO>> GetCustomers()
        {
            
            List<CustomerDTO> customers = await _client.GetFromJsonAsync<List<CustomerDTO>>("/api/Customer");
            return customers;
            
        }
        public bool RunningOnClient()
        {
            return true;
        }
    }
}
