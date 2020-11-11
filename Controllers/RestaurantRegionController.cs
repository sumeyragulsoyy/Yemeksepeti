using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Yemeksepeti.Dtos.RestaurantRegion;
using Yemeksepeti.Interfaces;

namespace Yemeksepeti.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[Controller]")]
    public class RestaurantRegionController : ControllerBase
    {
        private readonly IRestaurantRegionService _restaurantRegionService;
        public RestaurantRegionController(IRestaurantRegionService restaurantRegionService)
        {
            _restaurantRegionService = restaurantRegionService;

        }

        [HttpPost]
        public async Task<IActionResult> addDeliveryRegion(AddRestaurantRegionDto newRegionId){
            return Ok(await _restaurantRegionService.addDeliveryRegion(newRegionId));
        }

        [HttpDelete]
        public async Task<IActionResult> deleteDeliveryRegion(DeleteRestaurantRegionDto request){
            return Ok(await _restaurantRegionService.deleteDeliveryRegion(request));
        }
    }
}