using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Yemeksepeti.Dtos.Address;
using Yemeksepeti.Dtos.Customer;
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

        [HttpGet]
        public async Task<IActionResult> GetAll(){
            return Ok(await _customerService.getAll());
        }

        [HttpPost]
        public async Task<IActionResult> createCustomer(AddCustomerDto newCustomer){
            return Ok(await _customerService.createCustomer(newCustomer));
        }

        


    }
}