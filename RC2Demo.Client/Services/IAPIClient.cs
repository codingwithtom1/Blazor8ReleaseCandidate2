using RC2Demo.Shared;

namespace RC2Demo.Client.Services
{
    public interface IAPIClient
    {
        public Task<List<CustomerDTO>> GetCustomers();
        public bool RunningOnClient();

    }
}
