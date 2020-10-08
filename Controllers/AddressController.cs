using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Yemeksepeti.Dtos.Address;
using Yemeksepeti.Interfaces;

namespace Yemeksepeti.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;
        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;

        }
        
        [HttpPost]
        public async Task<IActionResult> addAddress(AddAddressDto address)
        {
            return Ok(await _addressService.addAddress(address));
        }
    }
}