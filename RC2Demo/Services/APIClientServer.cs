using RC2Demo.Client.Services;
using RC2Demo.Data;
using RC2Demo.Shared;

namespace RC2Demo.Services
{
    public class APIClientServer : IAPIClient
    {
        private readonly ApplicationDbContext _dbcontext;
        public APIClientServer(ApplicationDbContext db)
        {

            _dbcontext = db;
        }
        public async Task<List<CustomerDTO>> GetCustomers()
        {
            var results = _dbcontext.Customers;
            List<CustomerDTO> list = new List<CustomerDTO>();
            foreach (var customer in results)
            {
                list.Add(new CustomerDTO
                {
                    Id = customer.Id,
                    Name = customer.Name +"(Server)"
                });
            }
            return list;
        }
        public bool RunningOnClient()
        {
            return false;
        }
    }
}
