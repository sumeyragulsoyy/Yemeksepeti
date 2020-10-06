using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Yemeksepeti.Data;
using Yemeksepeti.Dtos.Customer;
using Yemeksepeti.Interfaces;
using Yemeksepeti.Models;

namespace Yemeksepeti.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly DataContext _context;
        public CustomerService(DataContext context)
        {
            _context = context;

        }
        public async Task<ServiceResponse<GetCustomerDto>> getCustomerById(int id)
        {
            ServiceResponse<GetCustomerDto> serviceResponse=new ServiceResponse<GetCustomerDto>();
            Customer customer=await _context.Customers.FirstOrDefaultAsync(c => c.Id ==id);
            // mapper ile dönmesi kaldı
              
        }
    }
}