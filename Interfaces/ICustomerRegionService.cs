using System.Threading.Tasks;
using Yemeksepeti.Dtos.CustomerRegion;
using Yemeksepeti.Models;

namespace Yemeksepeti.Interfaces
{
    public interface ICustomerRegionService
    {
        public  Task<ServiceResponse<string>> addAdress(AddCustomerRegionDto address);
        public  Task<ServiceResponse<GetCustomerRegionDto>> getCustomerAddress(ICustomerService customerService);
        
    }
}