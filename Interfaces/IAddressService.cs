using System.Threading.Tasks;
using Yemeksepeti.Dtos.Address;
using Yemeksepeti.Models;

namespace Yemeksepeti.Interfaces
{
    public interface IAddressService
    {
        Task<ServiceResponse<GetAddressDto>> addAddress(AddAddressDto Address);
    }
}