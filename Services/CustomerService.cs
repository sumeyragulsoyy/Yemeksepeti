using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Yemeksepeti.Data;
using Yemeksepeti.Dtos.Customer;
using Yemeksepeti.Interfaces;
using Yemeksepeti.Models;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace Yemeksepeti.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CustomerService(DataContext context, IMapper mapper,IHttpContextAccessor httpContextAccessor)
        {
            _mapper = mapper;
            _context = context;
            _httpContextAccessor=httpContextAccessor;
        }

        
        private int GetUserId() => int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
        private string GetUserRole() => _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Role);

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
            int user=GetUserId();
            Customer customer = await _context.Customers
            .FirstOrDefaultAsync(c => c.UserId == GetUserId());
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
            Customer.User =await _context.Users.FirstOrDefaultAsync(c =>c.Id==GetUserId());
            await _context.AddAsync(Customer);
            await _context.SaveChangesAsync();

            response.Data= _mapper.Map<GetCustomerDto>(Customer);
            return response;
        }

        public async Task<ServiceResponse<GetCustomerDto>> updateCustomer(UpdateCustomerDto customer)
        {
            ServiceResponse<GetCustomerDto> response=new ServiceResponse<GetCustomerDto>();
            Customer _customer= await _context.Customers
            .FirstOrDefaultAsync(c => c.UserId == GetUserId());

            _customer.Bonus=customer.Bonus;
            _customer.Name=customer.Name;
            _customer.PhoneNumber=customer.PhoneNumber;
            _customer.Surname=customer.Surname;

            await _context.SaveChangesAsync();
            response.Data=_mapper.Map<GetCustomerDto>(_customer);
            return response;
        }
    }
}