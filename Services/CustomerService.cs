using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
        private readonly IMapper _mapper;
        public CustomerService(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;

        }

        public async Task<ServiceResponse<List<GetCustomerDto>>> getAll()
        {
            ServiceResponse<List<GetCustomerDto>> response=new ServiceResponse<List<GetCustomerDto>>();
            List<Customer> customers = await _context.Customers.ToListAsync();
            
            response.Data=(customers.Select(x => _mapper.Map<GetCustomerDto>(x))).ToList();
            return response;
        }

        public async Task<ServiceResponse<GetCustomerDto>> getCustomerById(int id)
        {
            ServiceResponse<GetCustomerDto> serviceResponse = new ServiceResponse<GetCustomerDto>();
            Customer customer = await _context.Customers.FirstOrDefaultAsync(c => c.Id == id);
            if (customer == null)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Customer not found.";
                return serviceResponse;
            }
            serviceResponse.Data=_mapper.Map<GetCustomerDto>(customer);
            return serviceResponse;
        }
    }
}