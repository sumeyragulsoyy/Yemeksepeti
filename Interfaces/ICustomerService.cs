using System.Threading.Tasks;
using Yemeksepeti.Dtos.Customer;
using Yemeksepeti.Models;

namespace Yemeksepeti.Interfaces
{
    public interface ICustomerService
    {
        Task<ServiceResponse<GetCustomerDto>> getCustomerById(int id);
    }
}