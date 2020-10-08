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
            Customer customer = await _context.Customers
            .Include(c => c.Addres)
            .FirstOrDefaultAsync(c => c.Id == id);
            if (customer == null)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Customer not found.";
                return serviceResponse;
            }
            serviceResponse.Data=_mapper.Map<GetCustomerDto>(customer);
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCustomerDto>> createCustomer(AddCustomerDto customer)
        {
            ServiceResponse<GetCustomerDto> response= new ServiceResponse<GetCustomerDto>();
            Customer Customer = _mapper.Map<Customer>(customer);
            Customer.User =await _context.Users.FirstOrDefaultAsync(c =>c.Id==6);
            await _context.AddAsync(Customer);
            await _context.SaveChangesAsync();

            response.Data= _mapper.Map<GetCustomerDto>(Customer);
            return response;
        }

        
    }
}