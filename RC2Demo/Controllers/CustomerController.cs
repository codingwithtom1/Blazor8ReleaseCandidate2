using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RC2Demo.Data;
using RC2Demo.Shared;

namespace RC2Demo.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ApplicationDbContext _dbcontext;
        public CustomerController(ApplicationDbContext db)
        {

            _dbcontext = db;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDTO>>> Get()
        {
            var results = _dbcontext.Customers;
            List<CustomerDTO> list = new List<CustomerDTO>();
            foreach (var customer in results)
            { 
                list.Add(new CustomerDTO { 
                    Id = customer.Id, 
                    Name = customer.Name });
            }
            return Ok(list);   

        }
    }
}
