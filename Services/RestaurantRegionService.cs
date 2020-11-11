using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Yemeksepeti.Data;
using Yemeksepeti.Dtos.RestaurantRegion;
using Yemeksepeti.Interfaces;
using Yemeksepeti.Models;

namespace Yemeksepeti.Services
{
    public class RestaurantRegionService : IRestaurantRegionService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public RestaurantRegionService(DataContext context, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            _context = context;
        }
        private int GetUserId() => int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
        
        public async Task<ServiceResponse<bool>> addDeliveryRegion(AddRestaurantRegionDto newRegionId)
        {
            ServiceResponse<bool> response =new ServiceResponse<bool>();
            Restaurant restaurant =await _context.Restaurants.FirstOrDefaultAsync(x => x.UserId==GetUserId());
            Region region =await _context.Regions.FirstOrDefaultAsync(x => x.Id ==newRegionId.RegionId);
            if (region == null){
                response.Success=false;
                response.Message="Region is not found.";
                return response;
            }

            RestaurantRegion restaurantRegion=new RestaurantRegion{
                Restaurant=restaurant,
                Region=region
            };

            await _context.RestaurantRegions.AddAsync(restaurantRegion);
            await _context.SaveChangesAsync();
            response.Success=true;
            response.Data=true;           
            return response;
        }

        public async Task<ServiceResponse<bool>> deleteDeliveryRegion(DeleteRestaurantRegionDto deleteRegion)
        {
            ServiceResponse<bool> response=new ServiceResponse<bool>();
            Restaurant restaurant= await _context.Restaurants.FirstOrDefaultAsync(x => x.UserId==GetUserId());
            Region region =await _context.Regions.FirstOrDefaultAsync(x => x.Id ==deleteRegion.RegionId);
            if(region ==null){
                response.Success=false;
                response.Message="Region is not found";
            }
            RestaurantRegion willbedeleted =  _context.RestaurantRegions.Where(x => x.RestaurantId== restaurant.Id &&  x.RegionId==region.Id).FirstOrDefault();
            _context.RestaurantRegions.Remove(willbedeleted);
            await _context.SaveChangesAsync();
            response.Data=true;
            return response;

        }
    }
}