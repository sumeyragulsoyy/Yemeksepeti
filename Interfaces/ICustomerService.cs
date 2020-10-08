using System.Collections.Generic;
using System.Threading.Tasks;
using Yemeksepeti.Dtos.Customer;
using Yemeksepeti.Models;

namespace Yemeksepeti.Interfaces
{
    public interface ICustomerService
    {
        Task<ServiceResponse<GetCustomerDto>> getCustomerById(int id);

        Task<ServiceResponse<List<GetCustomerDto>>> getAll();

        Task<ServiceResponse<GetCustomerDto>> createCustomer(AddCustomerDto customer);
    }
}