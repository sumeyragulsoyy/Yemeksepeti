using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Yemeksepeti.Data;
using Yemeksepeti.Dtos.Restaurant;
using Yemeksepeti.Interfaces;
using Yemeksepeti.Models;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace Yemeksepeti.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpcontextAccessor;
        public RestaurantService(DataContext context, IMapper mapper,IHttpContextAccessor httpContextAccessor)
        {
            _mapper = mapper;
            _context = context;
            _httpcontextAccessor=httpContextAccessor;
        }

        private int GetUserId() => int.Parse(_httpcontextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
        private string GetUserRole() => _httpcontextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Role);
        public  async Task<ServiceResponse<GetRestaurantDto>> createRestaurant(AddRestaurantDto request)
        {
            ServiceResponse<GetRestaurantDto> response = new ServiceResponse<GetRestaurantDto>();
            Restaurant restaurant= _mapper.Map<Restaurant>(request);
            restaurant.User= await _context.Users.FirstOrDefaultAsync(x => x.Id==GetUserId());
            await _context.AddAsync(restaurant);
            await _context.SaveChangesAsync();

            response.Data= _mapper.Map<GetRestaurantDto>(restaurant);
            return response;
        }

        public Task<ServiceResponse<List<GetRestaurantDto>>> getAllRestaurant()
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<GetRestaurantDto>> getRestaurant()
        {
            throw new System.NotImplementedException();
        }
    }
}