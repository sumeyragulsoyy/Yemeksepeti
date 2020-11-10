using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Yemeksepeti.Dtos.Region;
using Yemeksepeti.Interfaces;

namespace Yemeksepeti.Controllers
{
    [Authorize(Roles = "Admin")]
    [ApiController]
    [Route("[Controller]")]
    public class RegionController : ControllerBase
    {
        private readonly IRegionService _regionService;
        public RegionController(IRegionService regionService)
        {
            _regionService = regionService;

        }

        [HttpGet]
        public async Task<IActionResult> GetAll(){
            return Ok(await _regionService.getAll());
        }

        [HttpPost]
        public async Task<IActionResult> AddRegion(AddRegionDto region){
             return Ok(await _regionService.addRegion(region));
        }
    }
}