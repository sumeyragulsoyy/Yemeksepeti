using System.Threading.Tasks;
using Yemeksepeti.Dtos.RestaurantRegion;
using Yemeksepeti.Models;

namespace Yemeksepeti.Interfaces
{
    public interface IRestaurantRegionService
    {
         public Task<ServiceResponse<bool>> addDeliveryRegion(AddRestaurantRegionDto newRegionId);
         public Task<ServiceResponse<bool>> deleteDeliveryRegion(DeleteRestaurantRegionDto regionId);
    }
}