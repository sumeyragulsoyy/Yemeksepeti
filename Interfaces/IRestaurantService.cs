using System.Collections.Generic;
using System.Threading.Tasks;
using Yemeksepeti.Dtos.Restaurant;
using Yemeksepeti.Models;

namespace Yemeksepeti.Interfaces
{
    public interface IRestaurantService
    {
         public Task<ServiceResponse<GetRestaurantDto>> createRestaurant(AddRestaurantDto request);
         public Task<ServiceResponse<GetRestaurantDto>> getRestaurant();
         public Task<ServiceResponse<List<GetRestaurantDto>>> getAllRestaurant();
    }
}