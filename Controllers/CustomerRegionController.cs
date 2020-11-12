using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Yemeksepeti.Interfaces;

namespace Yemeksepeti.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[Controller]")]
    public class CustomerRegionController : ControllerBase
    {
        private readonly ICustomerRegionService _customerRegionService;
        
        public CustomerRegionController(ICustomerRegionService customerRegionService)
        {
            _customerRegionService = customerRegionService;

        }

        [HttpGet]
        public async Task<IActionResult> getCustomerAddress([FromServices]ICustomerService _customerService){
            return Ok(await _customerRegionService.getCustomerAddress(_customerService));
        }
    }
}