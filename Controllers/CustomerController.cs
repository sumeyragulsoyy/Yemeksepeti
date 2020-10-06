using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Yemeksepeti.Interfaces;

namespace Yemeksepeti.Controllers
{

    [Route("[Controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerById(int id){
            return Ok(await _customerService.getCustomerById(id));
        }
    }
}