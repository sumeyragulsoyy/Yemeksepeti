using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Yemeksepeti.Dtos.Restaurant;
using Yemeksepeti.Interfaces;

namespace Yemeksepeti.Controllers
{
    [Authorize(Roles = "Restaurant")]
    [ApiController]
    [Route("[Controller]")]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantService _restaurantService;
        public RestaurantController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;

        }

        [HttpPost]
        public async Task<IActionResult> createRestaurant(AddRestaurantDto request)
        {
            return Ok(await _restaurantService.createRestaurant(request));
        }

        [HttpGet]
        public async Task<IActionResult> getRestaurant(){
           return Ok(await _restaurantService.getRestaurant());
        }

        [HttpGet("All")]
        public async Task<IActionResult> getAll(){
            return Ok(await _restaurantService.getAllRestaurant());
        }
    }
}